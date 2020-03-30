using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        VSTaskVar UnitsOfLengthVS = new VSTaskVar(
            (out ValueSet vs) =>
            {
                vs = Self.CreateValueSet(
                    "UnitsOfLengthVS",
                    "UnitsOfLength ValueSet",
                    "UnitsOfLength/ValueSet",
                    "UnitsOfLength value set.",
                    Group_CommonCodesVS);

                ValueSet.ConceptSetComponent vsComp = new ValueSet.ConceptSetComponent
                {
                    System = "http://unitsofmeasure.org"
                };

                vs.Compose = new ValueSet.ComposeComponent();
                vs.Compose.Include.Add(vsComp);

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "m",
                    Display = "meter"
                });

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "cm",
                    Display = "centimeter"
                });

                vsComp.Concept.Add(new ValueSet.ConceptReferenceComponent
                {
                    Code = "mm",
                    Display = "millimeter"
                });
            });
    }
}