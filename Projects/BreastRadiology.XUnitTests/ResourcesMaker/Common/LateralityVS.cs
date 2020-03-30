using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        VSTaskVar LateralityVS = new VSTaskVar(
            (out ValueSet vs) =>
            {
                vs = Self.CreateValueSet(
                    "LateralityVS",
                    "Laterality ValueSet",
                    "Laterality/ValueSet",
                    "Laterality value set.",
                    Group_CommonCodesVS);

                ValueSet.ConceptSetComponent vsComp = new ValueSet.ConceptSetComponent
                {
                    System = "http://snomed.info/sct"
                };

                vs.Compose = new ValueSet.ComposeComponent();
                vs.Compose.Include.Add(vsComp);

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "51440002",
                    Display = "Right and left"
                });

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "399488007",
                    Display = "Midline"
                });

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "85421007",
                    Display = "Structure of right half of body"
                });

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "31156008",
                    Display = "Structure of left half of body"
                });

            });
    }
}