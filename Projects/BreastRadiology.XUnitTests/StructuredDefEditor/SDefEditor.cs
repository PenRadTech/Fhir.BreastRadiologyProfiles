using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Newtonsoft.Json.Linq;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class SDefEditor
    {
        public StructureDefinition SDef => this.sDef;
        StructureDefinition baseSDef;
        StructureDefinition sDef;
        String basePath;
        String fragmentDir;
        String pageDir;
        ElementTreeNode snapNode;
        ElementTreeNode snapNodeOriginal;
        IConversionInfo info;
        public IntroDoc IntroDoc { get; set; }

        /// <summary>
        /// Create structure definition editor
        /// </summary>
        public SDefEditor(IConversionInfo info,
            String name,
            String url,
            String baseDefinition,
            String mapName,
            String fragmentDir,
            String pageDir)
        {
            this.info = info;
            this.fragmentDir = fragmentDir;
            this.pageDir = pageDir;
            this.baseSDef = FhirStructureDefinitions.Self.GetResource(baseDefinition);
            if (this.baseSDef == null)
                throw new Exception($"'Base definition resource {baseDefinition}' not found");

            this.basePath = baseDefinition.LastUriPart();

            {
                ElementTreeLoader l = new ElementTreeLoader();
                this.snapNode = l.Create(this.baseSDef.Snapshot.Element);
                this.snapNodeOriginal = this.snapNode.Clone();
            }

            this.sDef = new StructureDefinition
            {
                Name = name,
                Url = url,
                BaseDefinition = baseDefinition,
                Differential = new StructureDefinition.DifferentialComponent()
            };

            this.SDef.AddExtension(Global.ResourceMapNameUrl, new FhirString(mapName));
        }


        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// Note: Path is fhir path without the first element.
        /// ie. 'Observation.value[x]' is just 'value[x]'
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementTreeNode Get(String path)
        {
            // Note: First part is ignored, but has to be present.
            if (this.snapNode.TryGetChild(path, out ElementTreeNode retVal) == true)
                return retVal;
            throw new Exception($"'{path}' not found");
        }

        /// <summary>
        /// Select a element definition from the base sdef by its path name and 
        /// copy it to the differential of the output sdef.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public ElementDefinition Select(String path)
        {
            return this.Get(path).ElementDefinition;
        }

        public bool Write(out String fragmentName)
        {
            fragmentName = null;

            this.sDef.Snapshot = null;

            // Create differential by comparing current snapshot with original.
            ElementTreeNode differentialNode = this.snapNode.Clone();
            {
                ElementTreeDiffer differ = new ElementTreeDiffer(this.info);
                if (differ.Process(this.snapNodeOriginal, differentialNode) == false)
                    return false;
            }
            {
                ElementTreeSetBase setBase = new ElementTreeSetBase(this.info);
                if (setBase.Process(this.snapNodeOriginal, differentialNode) == false)
                    return false;
            }

            // Patch Path and Id's with correct basePath.
            differentialNode.ReplaceBasePath(this.basePath);

            {
                List<ElementDefinition> elementDefinitions = new List<ElementDefinition>();
                differentialNode.CopyTo(elementDefinitions);
                this.sDef.Differential.Element = elementDefinitions;
            }

            fragmentName = Path.Combine(this.fragmentDir, $"StructureDefinition-{this.sDef.Name}.json");

            // Make sure that all Observation resources that are not fragments, have Observation.code
            // fixed properly.
            if (
                (this.sDef.IsFragment() == false) &&
                (this.sDef.BaseDefinition == Global.ObservationUrl)
            )
            {
                if (this.snapNode.TryGetElementNode("Observation.code", out ElementTreeNode codeNode) == false)
                    throw new Exception("Observation.code not found");
                if (codeNode.ElementDefinition.Pattern == null)
                {
                    this.info.ConversionError(nameof(SDefEditor),
                        "Write",
                        $"Observation {this.SDef.Name} lacks fixed Observation.code.");
                }
            }

            SnapshotCreator.Create(this.sDef);

            this.sDef.SaveJson(fragmentName);
            return true;
        }

        public ElementTreeNode ConfigureSliceByUrlDiscriminator(String path, bool overrideExistingSliceDiscriminator)
        {
            ElementTreeNode extDef = this.Get(path);
            return this.ConfigureSliceByUrlDiscriminator(extDef, overrideExistingSliceDiscriminator);
        }

        public ElementTreeNode ConfigureSliceByUrlDiscriminator(ElementTreeNode extDef,
            bool overrideExistingSliceDiscriminator)
        {
            ElementDefinition.SlicingComponent slicingComponent = new ElementDefinition.SlicingComponent
            {
                Ordered = true,
                Rules = ElementDefinition.SlicingRules.OpenAtEnd
            };

            slicingComponent.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Value,
                Path = "url"
            });

            extDef.ApplySlicing(slicingComponent, overrideExistingSliceDiscriminator);
            return extDef;
        }

        public ElementTreeSlice ApplyExtension(String name,
            StructureDefinition sd,
            bool showChildren)
        {
            return this.ApplyExtension(name, sd.Url, showChildren);
        }

        public ElementTreeSlice ApplyExtension(ElementTreeNode extDef,
            String name,
            StructureDefinition sd)
        {
            return this.ApplyExtension(extDef, name, sd.Url);
        }

        public ElementTreeSlice ApplyExtension(String name,
            String extensionUrl,
            bool showChildren)
        {
            return this.ApplyExtension(this.Get("extension"), name, extensionUrl);
        }

        public ElementTreeSlice ApplyExtension(ElementTreeNode extDef,
            String name,
            String extensionUrl)
        {
            String sliceName = name.UncapFirstLetter();
            this.ConfigureSliceByUrlDiscriminator(extDef, true);


            ElementTreeSlice slice = extDef.CreateSlice(sliceName);
            slice.ElementDefinition.Min = 0;
            slice.ElementDefinition.Max = "*";

            slice.ElementDefinition
                .SetShort($"{name} extension.")
                .SetDefinition(new Markdown()
                    .Paragraph($"This extension slice contains the {name} extension."))
                .SetComment(ResourcesMaker.componentDefinition)
                ;

            slice.ElementDefinition.IsModifier = false;
            slice.ElementDefinition.Type.Add(new ElementDefinition.TypeRefComponent
            {
                Code = "Extension",
                Profile = new String[] { extensionUrl }
            });
            return slice;
        }

        /// <summary>
        /// Sets the .Description field, and also sets the ElementDefinition.Short and .Description fields
        /// of the first element definition.
        /// </summary>
        /// <param name="descriptionHeader"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public SDefEditor Description(String descriptionHeader, Markdown value)
        {
            {
                Markdown description = new Markdown();
                description.Value += $"<b>{descriptionHeader}</b>\n\n";
                description.Value += value.Value;
                this.sDef.Description(description);
            }

            this.snapNode.ElementDefinition.Short = descriptionHeader;
            this.snapNode.ElementDefinition.Definition = value;
            return this;
        }

        public SDefEditor ContactUrl(String value)
        {
            this.sDef.ContactUrl(value);
            return this;
        }

        public SDefEditor Publisher(String value)
        {
            this.sDef.Publisher(value);
            return this;
        }

        public SDefEditor Title(String value)
        {
            this.sDef.Title(value);
            return this;
        }

        public SDefEditor Status(PublicationStatus? value)
        {
            this.sDef.Status(value);
            return this;
        }

        public SDefEditor Date(FhirDateTime value)
        {
            this.sDef.Date(value);
            return this;
        }

        public SDefEditor Derivation(StructureDefinition.TypeDerivationRule? value)
        {
            this.sDef.Derivation(value);
            return this;
        }

        public SDefEditor Abstract(bool? value)
        {
            this.sDef.Abstract(value);
            return this;
        }

        public SDefEditor Kind(StructureDefinition.StructureDefinitionKind? value)
        {
            this.sDef.Kind(value);
            return this;
        }

        public SDefEditor Version(String value)
        {
            this.sDef.Version(value);
            return this;
        }

        public SDefEditor Type(String value)
        {
            this.sDef.Type(value);
            return this;
        }

        public SDefEditor Context(
            StructureDefinition.ExtensionContextType type = StructureDefinition.ExtensionContextType.Element,
            String expression = "*")
        {
            this.sDef.Context(type, expression);
            return this;
        }

        public SDefEditor SetIsFrag()
        {
            this.SDef.Extension.Add(new Extension
            {
                Url = PreFhirGenerator.IsFragmentUrl,
                Value = new FhirBoolean(true)
            });
            return this;
        }

        public SDefEditor AddFragRef(StructureDefinition sd)
        {
            if (sd.IsFragment() == false)
                throw new Exception("Expected a fragment");

            String fragRef = sd.Url;
            if (String.IsNullOrWhiteSpace(fragRef))
                throw new Exception($"Fragment Url must not be empty");
            this.SDef.Extension.Add(new Extension
            {
                Url = PreFhirGenerator.FragmentUrl,
                Value = new FhirUrl(fragRef)
            });

            dynamic packet = new JObject();
            packet.LinkType = "fragment";
            packet.ShowChildren = false;
            packet.LinkTarget = sd.Url;
            this.SDef.AddExtension(Global.ResourceMapLinkUrl, new FhirString(packet.ToString()));
            return this;
        }

        public class Cardinality
        {
            Int32 min;
            String max;

            public Cardinality(ElementDefinition e)
            {
                this.min = e.Min.Value;
                this.max = e.Max;
            }

            public Cardinality(Int32 min, String max)
            {
                this.min = min;
                this.max = max;
            }

            public override string ToString() => $"{this.min}..{this.max}";
        }

        public SDefEditor AddExtensionLink(String url,
            Cardinality cardinalityLeft,
            String localName,
            String componentRef,
            bool showChildren)
        {
            this.sDef.AddExtensionLink(url, cardinalityLeft, localName, componentRef, showChildren);
            return this;
        }

        public SDefEditor AddComponentLink(String url,
            Cardinality cardinalityLeft,
            Cardinality cardinalityRight,
            String componentRef,
            String types,
            params String[] targets)
        {
            this.sDef.AddComponentLink(url,
                cardinalityLeft,
                cardinalityRight,
                componentRef,
                types,
                targets);
            return this;
        }


        public SDefEditor AddTargetLink(String url, Cardinality cardinalityLeft, bool showChildren)
        {
            this.SDef.AddTargetLink(url, cardinalityLeft, showChildren);
            return this;
        }

        public SDefEditor AddValueSetLink(ValueSet vs, bool showChildren)
        {
            this.SDef.AddValueSetLink(vs, showChildren);
            return this;
        }

        public ElementTreeSlice AppendSlice(String elementName,
            String sliceName,
            Int32 min = 0,
            String max = "*")
        {
            ElementTreeNode elementDef = this.Get(elementName);
            ElementTreeSlice retVal = elementDef.CreateSlice(sliceName);
            retVal.ElementDefinition.Min = min;
            retVal.ElementDefinition.Max = max;
            return retVal;
        }

        public ElementTreeNode ApplySliceSelf(String path)
        {
            ElementDefinition.SlicingComponent slicing = new ElementDefinition.SlicingComponent
            {
                Rules = ElementDefinition.SlicingRules.Open
            };

            slicing.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Type,
                Path = "$this"
            });
            ElementTreeNode elementDef = this.Get(path);
            elementDef.ApplySlicing(slicing, false);
            return elementDef;
        }

        public ElementDefinition SliceSelfByPattern(String path,
            String sliceName,
            Element pattern)
        {
            ElementTreeNode elementDef = ApplySliceSelf(path);

            sliceName = sliceName.UncapFirstLetter();
            ElementTreeSlice codingSlice = elementDef.CreateSlice(sliceName);
            codingSlice.ElementDefinition.Pattern = pattern;
            return codingSlice.ElementDefinition;
        }

        public ElementTreeSlice SliceByUrlTarget(ElementTreeNode sliceElementDef,
            String profileUrl,
            Int32 min,
            String max)
        {
            String sliceName = profileUrl.LastUriPart().UncapFirstLetter();
            ElementTreeSlice slice = sliceElementDef.CreateSlice(sliceName);
            slice.ElementDefinition.SetCardinality(min, max);
            slice.ElementDefinition.Type.Clear();
            slice.ElementDefinition.Type.Add(new ElementDefinition.TypeRefComponent
            {
                Code = "Reference",
                TargetProfile = new String[] { profileUrl }
            });
            return slice;
        }

        public void AddIncompatibleFragment(String url)
        {
            this.SDef.AddExtension(Global.IncompatibleFragmentUrl, new FhirUrl(url));
        }

        public void StartComponentSliceing()
        {
            ElementTreeNode componentNode = this.Get("component");

            ElementDefinition.SlicingComponent slicingComponent = new ElementDefinition.SlicingComponent
            {
                Rules = ElementDefinition.SlicingRules.Open
            };

            slicingComponent.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Pattern,
                Path = "code"
            });

            componentNode.ApplySlicing(slicingComponent, false);
        }

        public ElementTreeSlice ComponentSliceCodeableConcept(String sliceName,
            CodeableConcept pattern,
            ValueSet valueSet,
            BindingStrength bindingStrength,
            Int32 minCardinality,
            String maxCardinality,
            String componentName,
            String sliceDefinitionText,
            Modalities modalities = Modalities.All)
        {
            String compStr = maxCardinality == "1" ? compStr = "component" : "components";
            Markdown sliceDefinition;

            {
                String introStr;
                if (minCardinality == 0)
                {
                    if (maxCardinality == "1")
                        introStr = "This slice contains the optional component";
                    else
                        introStr = "This slice contains the optional components";
                }
                else
                {
                    if (maxCardinality == "1")
                        introStr = "This slice contains the required component";
                    else
                        introStr = "This slice contains the required components";
                }

                sliceDefinition = new Markdown()
                    .Paragraph($"{introStr} that {sliceDefinitionText}.",
                        $"The value of this component is a codeable concept chosen from the {valueSet.Name} valueset.");
            }

            ElementTreeSlice slice = this.AppendSlice("component", sliceName, minCardinality, maxCardinality);
            slice.ElementDefinition
                .SetShort($"{componentName} component.")
                .SetDefinition(sliceDefinition)
                .SetComment(ResourcesMaker.componentDefinition)
                ;

            if (modalities != Modalities.All)
            {
                slice.ElementDefinition.Definition
                    .ValidModalities(modalities);
            }

            if (String.IsNullOrWhiteSpace(pattern.Coding[0].Display))
                throw new Exception($"Display null on coding {pattern.Coding[0].Code}");
            {
                ElementDefinition componentCode = new ElementDefinition
                {
                    Path = $"{slice.ElementDefinition.Path}.code",
                    ElementId = $"{slice.ElementDefinition.Path}:{sliceName}.code",
                    Min = 1,
                    Max = "1",
                    Short = $"{componentName} component code",
                    Definition = new Markdown()
                        .Paragraph($"This code identifies the {componentName} {compStr}.",
                            $"Its value shall always be the concept '{pattern.Coding[0].Display}'")
                };
                componentCode
                    .Pattern(pattern.ToPattern())
                    .DefaultValueExtension(pattern)
                    ;
                slice.CreateNode(componentCode);
            }
            {
                ElementDefinition valueX = new ElementDefinition
                {
                    Path = $"{slice.ElementDefinition.Path}.value[x]",
                    ElementId = $"{slice.ElementDefinition.Path}:{sliceName}.value[x]",
                    Min = 1,
                    Max = "1",
                    Short = $"{componentName} component value",
                };
                valueX
                    .Binding(valueSet, bindingStrength)
                    .Type("CodeableConcept")
                    .SetDefinition(new Markdown()
                        .Paragraph("Value is a codeable concept.")
                    )
                    ;
                slice.CreateNode(valueX);
            }

            String componentRef = Global.ElementAnchor(slice.ElementDefinition);
            this.AddComponentLink(componentName,
                new SDefEditor.Cardinality(slice.ElementDefinition),
                null,
                componentRef,
                "CodeableConcept",
                valueSet.Url);

            return slice;
        }

        public ElementTreeNode SliceComponentCode(ElementTreeSlice slice,
            String sliceName,
            CodeableConcept sliceCode)
        {
            ElementDefinition componentCode = new ElementDefinition
            {
                Path = $"{slice.ElementDefinition.Path}.code",
                ElementId = $"{slice.ElementDefinition.Path}:{sliceName}.code",
                Min = 1,
                Max = "1"
            };
            componentCode
                .Pattern(sliceCode.ToPattern())
                .DefaultValueExtension(sliceCode)
                ;
            return slice.CreateNode(componentCode);
        }

        public ElementTreeNode SliceValueXByType(ElementTreeSlice slice,
            String[] types)
        {
            ElementDefinition valueX = new ElementDefinition
            {
                Path = $"{slice.ElementDefinition.Path}.value[x]",
                ElementId = $"{slice.ElementDefinition.ElementId}.value[x]",
                Min = 1,
                Max = "1"
            };
            valueX
                .Types(types)
                ;

            ElementDefinition.SlicingComponent slicingComponent = new ElementDefinition.SlicingComponent
            {
                Rules = ElementDefinition.SlicingRules.Closed
            };

            slicingComponent.Discriminator.Add(new ElementDefinition.DiscriminatorComponent
            {
                Type = ElementDefinition.DiscriminatorType.Type,
                Path = "$this"
            });

            valueX.ApplySlicing(slicingComponent, false);

            return slice.CreateNode(valueX);
        }


        public ElementTreeSlice SliceTargetReference(ElementTreeNode sliceElementDef,
            StructureDefinition profile,
            Int32 min = 0,
            String max = "*")
        {
            String baseName = sliceElementDef.ElementDefinition.Path.LastPathPart();
            ElementTreeSlice retVal = this.SliceByUrlTarget(sliceElementDef, profile.Url, min, max);
            retVal.ElementDefinition
                .SetShort($"'{profile.Title}' reference.")
                .SetDefinition(
                    new Markdown()
                        .Paragraph($"This slice references the target '{profile.Title}'.")
                )
                ;
            this.AddTargetLink(profile.Url.Trim(),
                new SDefEditor.Cardinality(retVal.ElementDefinition),
                false);

            return retVal;
        }

        public void SliceTargetReference(ElementTreeNode sliceElementDef,
            StructureDefinition profile,
            Modalities modalities,
            Int32 min = 0,
            String max = "*")
        {
            String baseName = sliceElementDef.ElementDefinition.Path.LastPathPart();
            ElementDefinition sliceDef = this.SliceByUrlTarget(sliceElementDef, profile.Url, min, max).ElementDefinition
                    .SetShort($"'{profile.Title}' reference.")
                    .SetDefinition(
                        new Markdown()
                            .Paragraph($"This slice references the target '{profile.Title}'.")
                    )
                ;
            this.AddTargetLink(profile.Url,
                new SDefEditor.Cardinality(sliceDef),
                false);
        }

        public void SliceComponentSize(String sliceName,
            CodeableConcept componentCode,
            ValueSet units,
            Int32 min,
            String max,
            out ElementTreeSlice slice)
        {
            slice = this.AppendSlice("component", sliceName, min, max);
            this.SliceComponentCode(slice, sliceName, componentCode);
            SliceSize(slice, units);
        }

        public void SliceSize(ElementTreeSlice slice,
            ValueSet units)
        {
            // Fix component code
            ElementTreeNode valueXNode = this.SliceValueXByType(slice,
                new string[] { "Quantity", "Range" });
            {
                Hl7.Fhir.Model.Quantity q = new Hl7.Fhir.Model.Quantity
                {
                    System = units.Url
                };

                ElementDefinition valueX = new ElementDefinition
                {
                    Path = $"{slice.ElementDefinition.Path}.value[x]",
                    ElementId = $"{slice.ElementDefinition.ElementId}.value[x]:valueQuantity",
                    SliceName = $"valueQuantity",
                    Min = 0,
                    Max = "1"
                }
                        .Pattern(q)
                        .Type("Quantity")
                    ;
                valueXNode.CreateSlice($"valueQuantity", valueX);
            }

            {
                Hl7.Fhir.Model.Range r = new Hl7.Fhir.Model.Range
                {
                    Low = new SimpleQuantity
                    {
                        System = units.Url,
                    },
                    High = new SimpleQuantity
                    {
                        System = units.Url,
                    }
                };
                ElementDefinition valueX = new ElementDefinition
                {
                    Path = $"{slice.ElementDefinition.Path}.value[x]",
                    ElementId = $"{slice.ElementDefinition.ElementId}.value[x]:valueRange",
                    SliceName = $"valueRange",
                    Min = 0,
                    Max = "1"
                }
                        .Pattern(r)
                        .Type("Range")
                    ;
                valueXNode.CreateSlice($"valueRange", valueX);
            }
        }
    }
}