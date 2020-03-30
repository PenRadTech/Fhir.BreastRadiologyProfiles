using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using PreFhir;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker : ConverterBase
    {


        CSTaskVar BreastLandmarkCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "BreastLandmarkCS",
                    "Breast Landmark CodeSystem",
                    "Breast Landmark/CodeSystem",
                    "Breast Landmark CodeSystem defines the various breast body locations that can be used as a land mark.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        #region Codes
                        new ConceptDef()
                            .SetCode("Nipple")
                            .SetDisplay("Nipple")
                            .SetDefinition("Breast nipple land mark.")
                        ,
                        new ConceptDef()
                            .SetCode("ChestWall")
                            .SetDisplay("ChestWall")
                            .SetDefinition("Breast nipple land mark.")
                        ,
                        new ConceptDef()
                            .SetCode("Skin")
                            .SetDisplay("Skin")
                            .SetDefinition("Skin land mark.")
                        ,
                        #endregion // Codes
                    }
                )
        );


        VSTaskVar BreastLandmarkVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "BreastLandmarkVS",
                    "Breast Landmark  ValueSet",
                    "Breast Landmark /ValueSet",
                    "Breast Landmark value set.",
                    Group_CommonCodesVS,
                    Self.BreastLandmarkCS.Value()
                )
        );

        public SDTaskVar BodyDistanceFromExtension = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e;
                ElementTreeNode extensionNode;

                e = Self.CreateEditor("BodyDistanceFromExtension",
                            "Body Distance From Extension",
                            "Body Dist. From",
                            Global.ExtensionUrl,
                            $"{Group_ExtensionResources}/BreastBodyLocation",
                            "Extension")
                        .Description("Body Distance From extension",
                            new Markdown()
                                .Paragraph(
                                    "This complex extension adds fields that form a distance measurement from a specified body landmark.",
                                    "The body landmark is defined by a codeable concept",
                                    "The distance is defined by a quantity of metric distance units (cm, mm, etc)."
                                )
                        )
                        .Kind(StructureDefinition.StructureDefinitionKind.ComplexType)
                        .Context()
                    ;
                s = e.SDef;

                e.AddFragRef(Self.HeaderFragment);

                e.Select("url")
                    .Type("uri")
                    .Fixed(new FhirUri(e.SDef.Url));

                e.Select("value[x]").Zero();

                extensionNode = e.ConfigureSliceByUrlDiscriminator("extension", true);
                ValueSet landMarkBinding = Self.BreastLocationQuadrantVS.Value();

                // Slice land mark.
                {
                    Self.Slice(e,
                        extensionNode,
                        "landMark",
                        "Body landmark. Origin of distance measurement.",
                        new Markdown()
                            .Paragraph("Body landmark which defines the origin of the measurement.")
                            .Paragraph(
                                "Currently the value set this is bound to does not contain the required breast landmarks like nipple."),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode
                    );
                    extensionSlice.ElementDefinition
                        .Single()
                        ;
                    valueXNode.ElementDefinition
                        .Binding(landMarkBinding, BindingStrength.Extensible)
                        .Type("CodeableConcept")
                        .Single()
                        ;
                    e.AddComponentLink("Landmark",
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        null,
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        "CodeableConcept",
                        landMarkBinding.Url);
                }
                {
                    String sliceName = "distanceFromLandMark";

                    Self.Slice(e,
                        extensionNode,
                        sliceName,
                        "Distance from landmark",
                        new Markdown("Distance from body landmark to body location"),
                        out ElementTreeSlice extensionSlice,
                        out ElementTreeNode valueXNode);
                    extensionSlice.ElementDefinition
                        .Single()
                        ;
                    String binding = Self.UnitsOfLengthVS.Value().Url;
                    valueXNode.ElementDefinition
                        .Type("Quantity")
                        .Binding(binding, BindingStrength.Required)
                        .Single()
                        ;

                    e.AddComponentLink("Distance From LandMark",
                        new SDefEditor.Cardinality(extensionSlice.ElementDefinition),
                        null,
                        Global.ElementAnchor(extensionSlice.ElementDefinition),
                        "Quantity",
                        binding);
                }

                e.IntroDoc
                    .ReviewedStatus("Needs review by KWA")
                    .ReviewedStatus("Needs review by Penrad")
                    .ReviewedStatus("Needs review by MRS")
                    .ReviewedStatus("Needs review by MagView")
                    .ReviewedStatus("Needs review by CIMI")
                    ;
            });
    }
}