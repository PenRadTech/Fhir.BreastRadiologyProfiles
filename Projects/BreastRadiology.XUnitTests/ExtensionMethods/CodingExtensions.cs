using System;
using System.Collections.Generic;
using System.Text;
using Hl7.Fhir.Model;

namespace BreastRadiology.XUnitTests
{
    public static class CodingExtensions
    {
        public static CodeableConcept ToCodeableConcept(this Coding coding)
        {
            CodeableConcept retVal = new CodeableConcept(coding.System, coding.Code, coding.Display, coding.Display);
            return retVal;
        }

        /// <summary>
        /// Convert a coding to a codeable concept suitable for use in a pattern.
        /// We dont want to constrain the display and text in a pettern, so just copy the
        /// system and code
        /// </summary>
        public static Coding ToPattern(this Coding coding)
        {
            return new Coding(coding.System, coding.Code);
        }

        /// <summary>
        /// Convert a coding to a codeable concept suitable for use in a pattern.
        /// We dont want to constrain the display and text in a pettern, so just copy the
        /// system and code
        /// </summary>
        public static CodeableConcept ToPattern(this CodeableConcept concept)
        {
            if (concept.Coding.Count != 1)
                throw new NotImplementedException("Currently only handle single concept.");

            Coding coding = concept.Coding[0];
            CodeableConcept retVal = new CodeableConcept();
            retVal.Coding.Add(new Coding(coding.System, coding.Code));
            return retVal;
        }
    }
}