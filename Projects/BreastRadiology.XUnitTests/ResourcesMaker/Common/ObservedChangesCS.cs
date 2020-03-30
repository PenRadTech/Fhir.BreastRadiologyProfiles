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
        CSTaskVar ObservedChangesCS = new CSTaskVar(
            (out CodeSystem cs) =>
                cs = Self.CreateCodeSystem(
                    "ObservedChangesCS",
                    "Observed Changes CodeSystem",
                    "Observed/Change/CodeSystem",
                    "Observed changes in an abnormality code system.",
                    Group_CommonCodesCS,
                    new ConceptDef[]
                    {
                        //+ Codes
                        #region Codes
                        new ConceptDef()
                            .SetCode("DecreaseInCalcifications")
                            .SetDisplay("Decrease in calcifications")
                            .MammoId("484")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("484",
                                "F-01727")
                            .SetSnomedCode("484",
                                "129727007")
                            .SetSnomedDescription("484",
                                "ClinicalFinding | Decrease in number of calcifications ",
                                "since previous mammogram (Finding)")
                            .SetUMLS("484",
                                "There is a decrease in the number of calcifications ",
                                "found in this mammogram versus ",
                                "the prior mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("DecreaseInNumber")
                            .SetDisplay("Decrease in number")
                            .MammoId("482")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("482",
                                "ClinicalFinding | 42915007 | Abnormal decrease in ",
                                "number (Finding)")
                            .SetUMLS("482",
                                "There is a decrease in the number of calcifications ",
                                "found in this mammogram versus ",
                                "the prior mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("DecreaseInSize")
                            .SetDisplay("Decrease in size")
                            .MammoId("78")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetDicom("78",
                                "M-02530")
                            .SetSnomedCode("78",
                                "19776001")
                            .SetSnomedDescription("78",
                                "ClinicalFinding | 19776001 | Decreased size (Finding)")
                            .SetUMLS("78",
                                "The lesion/mass has decreased in size since prior ",
                                "MRI, Nuclear Medicine, Ultrasound and or/Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("IncreaseInCalcifications")
                            .SetDisplay("Increase in calcifications")
                            .MammoId("483")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("483",
                                "F-01726")
                            .SetSnomedCode("483",
                                "129726003")
                            .SetSnomedDescription("483",
                                "ClinicalFinding | Increase in number of calcifications ",
                                "since previous mammogram (Finding)")
                            .SetUMLS("483",
                                "Calcifications have increased in number from previous ",
                                "Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("IncreaseInNumber")
                            .SetDisplay("Increase in number")
                            .MammoId("481")
                            .ValidModalities(Modalities.MG)
                            .SetSnomedDescription("481",
                                "ClinicalFinding | 61515005 | Abnormal increase in ",
                                "number (Finding)")
                            .SetUMLS("481",
                                "There is an increase in the number of calcifications ",
                                "found in this mammogram versus ",
                                "the prior mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("IncreaseInSize")
                            .SetDisplay("Increase in size")
                            .MammoId("77")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetDicom("77",
                                "M-02520")
                            .SetSnomedCode("77",
                                "15454001")
                            .SetSnomedDescription("77",
                                "ClinicalFinding | 15454001 | Increased size (Finding)")
                            .SetUMLS("77",
                                "The mass has increased in size from the last Nuclear ",
                                "Medicine, ultrasound, MRI or mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("LessProminent")
                            .SetDisplay("Less prominent")
                            .MammoId("293")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetDicom("293",
                                "F-01728")
                            .SetSnomedCode("293",
                                "129728002")
                            .SetSnomedDescription("293",
                                "ClinicalFinding | 129728002 | Finding less well defined ",
                                "since previous mammogram (Finding)")
                            .SetUMLS("293",
                                "Less prominent")
                        ,
                        new ConceptDef()
                            .SetCode("MoreProminent")
                            .SetDisplay("More prominent")
                            .MammoId("294")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetDicom("294",
                                "F-01729")
                            .SetSnomedCode("294",
                                "129729005")
                            .SetSnomedDescription("294",
                                "ClinicalFinding | 129729005 | Finding more defined ",
                                "since previous mammogram (Finding)")
                            .SetUMLS("294",
                                "More prominent")
                        ,
                        new ConceptDef()
                            .SetCode("New")
                            .SetDisplay("New")
                            .MammoId("75")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetDicom("75",
                                "F-01721")
                            .SetSnomedCode("75",
                                "129721008")
                            .SetSnomedDescription("75",
                                "ClinicalFinding | 129721008 | New finding since previous ",
                                "mammogram (Finding)")
                            .SetUMLS("75",
                                "There are new masses/lesions present since last Mammogram, ",
                                "MRI, Nuclear Medicine and/or Ultrasound.")
                        ,
                        new ConceptDef()
                            .SetCode("NoLongerSeen")
                            .SetDisplay("No longer seen")
                            .MammoId("296")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("296",
                                "The lesion or mass is no longer seen from previous ",
                                "Mammogram, Ultrasound and/or MRI.")
                        ,
                        new ConceptDef()
                            .SetCode("NotSignificantChanged")
                            .SetDisplay("Not significant changed")
                            .MammoId("76")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetDicom("76",
                                "F-01723")
                            .SetSnomedCode("76",
                                "129723006")
                            .SetSnomedDescription("76",
                                "ClinicalFinding | 129723006 | No significant change ",
                                "since previous mammogram (Finding)")
                            .SetUMLS("76",
                                "The mass/lesion has not significantly changed since ",
                                "the last Mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("PartiallyRemoved")
                            .SetDisplay("Partially removed")
                            .MammoId("295")
                            .ValidModalities(Modalities.MG)
                            .SetDicom("295",
                                "F-01722")
                            .SetSnomedCode("295",
                                "129722001")
                            .SetSnomedDescription("295",
                                "ClinicalFinding | 129722001 | Finding partially removed ",
                                "since previous mammogram (Finding)")
                            .SetUMLS("295",
                                "The mass was partially removed since last mammogram.")
                        ,
                        new ConceptDef()
                            .SetCode("RepresentsChange")
                            .SetDisplay("Represents change")
                            .MammoId("298")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.NM | Modalities.US)
                            .SetUMLS("298",
                                "Represents change")
                        ,
                        new ConceptDef()
                            .SetCode("Stable")
                            .SetDisplay("Stable")
                            .MammoId("297")
                            .ValidModalities(Modalities.MG | Modalities.MRI | Modalities.US)
                            .SetUMLS("297",
                                "The condition has remained stable since the last ",
                                "Mammogram, Ultrasound, MRI or Nuclear ",
                                "Medicine exam.")
                        #endregion // Codes
                        //- Codes
                    }));

        VSTaskVar ObservedChangesVS = new VSTaskVar(
            (out ValueSet vs) =>
                vs = Self.CreateValueSet(
                    "ObservedChangesVS",
                    "Observed Changes ValueSet",
                    "Observed/Change/ValueSet",
                    "Observed changes in an abnormality value set.",
                    Group_CommonCodesVS,
                    Self.ObservedChangesCS.Value()
                )
        );
    }
}
