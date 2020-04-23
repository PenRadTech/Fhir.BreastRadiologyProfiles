using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Eir.DevTools;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {
        void SliceAndBindUrl(SDefEditor e,
            ElementTreeNode extensionNode,
            String sliceName,
            String bindName,
            String shortText,
            Markdown definition,
            out ElementTreeSlice extensionSlice,
            out ElementTreeNode valueXNode)
        {
            this.Slice(e, extensionNode, sliceName, shortText, definition, out extensionSlice, out valueXNode);
            valueXNode.ElementDefinition
                .Type("CodeableConcept")
                .Binding(bindName, BindingStrength.Required)
                .Single()
                ;
        }

        ElementDefinition SliceAndBindVS(SDefEditor e,
            ElementTreeNode extensionNode,
            String sliceName,
            ValueSet binding,
            String shortText,
            Markdown definition)
        {
            this.SliceAndBindUrl(e,
                extensionNode,
                sliceName,
                binding.Url,
                shortText,
                definition,
                out ElementTreeSlice extensionSlice,
                out ElementTreeNode valueXNode);
            return extensionSlice.ElementDefinition;
        }

        void Slice(SDefEditor e,
            ElementTreeNode extensionNode,
            String sliceName,
            String shortText,
            Markdown definition,
            out ElementTreeSlice extensionSlice,
            out ElementTreeNode valueXNode)
        {
            extensionSlice = extensionNode.CreateSlice(sliceName);
            extensionSlice.ElementDefinition
                .ElementId($"{extensionNode.ElementDefinition.Path}:{sliceName}")
                .SliceName(sliceName)
                .Short(shortText)
                .Definition(definition)
                .SetCardinality(0, "1")
                ;
            extensionSlice.ElementDefinition.Type = null;

            {
                ElementDefinition sealExtension = new ElementDefinition
                {
                    ElementId = $"{extensionNode.ElementDefinition.Path}:{sliceName}.extension",
                    Path = $"{extensionNode.ElementDefinition.Path}.extension"
                };

                sealExtension.Zero();
                extensionSlice.CreateNode(sealExtension);
            }
            {
                ElementDefinition elementUrl = new ElementDefinition()
                        .Path($"{extensionNode.ElementDefinition.Path}.url")
                        .ElementId($"{extensionNode.ElementDefinition.Path}:{sliceName}.url")
                        .Value(new FhirUri(sliceName))
                        .Type("uri")
                        .Definition(new Markdown()
                            .Paragraph($"Url for {sliceName} complex extension item.")
                        )
                    ;
                extensionSlice.CreateNode(elementUrl);
            }

            {
                ElementDefinition valueBase = e.Get("value[x]").ElementDefinition;
                ElementDefinition elementValue = new ElementDefinition()
                        .Path($"{extensionNode.ElementDefinition.Path}.value[x]")
                        .ElementId($"{extensionNode.ElementDefinition.Path}:{sliceName}.value[x]")
                    ;
                valueXNode = extensionSlice.CreateNode(elementValue);
            }
        }
    }
}