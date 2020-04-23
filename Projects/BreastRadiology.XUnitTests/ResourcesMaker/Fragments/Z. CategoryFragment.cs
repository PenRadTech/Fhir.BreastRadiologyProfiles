using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    partial class ResourcesMaker
    {
        SDTaskVar CategoryFragment = new SDTaskVar(
            (out StructureDefinition s) =>
            {
                SDefEditor e = Self.CreateFragment("CategoryFragment",
                        "Category Fragment",
                        "Category/Fragment",
                        Global.ObservationUrl)
                    .Description("Fix Observation.category Fragment",
                        new Markdown()
                            .Paragraph(
                                "This fragment slices Observation.category and fixes the observation.code value to 'imaging'.")
                    );
                s = e.SDef;

                {
                    ElementTreeNode eDef = e.Get("category");
                    eDef.ElementDefinition.Card(1, eDef.ElementDefinition.Max);
                }

                e.SliceSelfByPattern("category",
                        "categoryImaging",
                        new CodeableConcept("http://terminology.hl7.org/CodeSystem/observation-category", "imaging"))
                    .Single()
                    ;
            });
    }
}