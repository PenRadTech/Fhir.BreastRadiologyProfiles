using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using PreFhir;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar BreastBodyLocationRequiredFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("BreastBodyLocationRequiredFragment",
                            "Breast Body Location (Required) Fragment",
                            "Breast Body Location/Fragment (Required)",
                            Global.ObservationUrl)
                        .Description("Required Breast Body Location fragment",
                            new Markdown()
                                .Paragraph("This fragment adds the references for the breast body location extension.")
                                .Paragraph(
                                    "The references are required, meaning that the breast body location must exist.")
                        )
                        .AddFragRef(Self.HeaderFragment)
                    ;
                s = e.SDef;

                e
                    .Select("bodySite")
                    .Single()
                    ;

                ElementDefinition extension = new ElementDefinition
                        {
                            ElementId = "Observation.bodySite.extension",
                            Path = "Observation.bodySite.extension",
                        }
                        .ZeroToMany()
                        .Type("Extension")
                    ;
                ElementTreeNode bodySiteNode = e.Get("bodySite");
                ElementTreeNode extensionNode = bodySiteNode.DefaultSlice.CreateNode(extension);
                {
                    StructureDefinition extensionStructDef = Self.BreastBodyLocationExtension.Value();
                    ElementDefinition extensionDef = e
                            .ApplyExtension(extensionNode, "breastBodyLocation", extensionStructDef).ElementDefinition
                            .Single()
                        ;

                    e.AddExtensionLink(extensionStructDef.Url,
                        new SDefEditor.Cardinality(extensionDef),
                        "Breast Body Location",
                        Global.ElementAnchor(extensionDef),
                        false);
                }
            });
    }
}