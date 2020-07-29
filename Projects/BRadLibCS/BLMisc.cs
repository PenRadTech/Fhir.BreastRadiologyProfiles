using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRadLibCS
{
    public static class BLMisc
    {
        public static bool SameUrl(String url1, String url2)
        {
            url1 = url1.ToUpper().Trim();
            url2 = url2.ToUpper().Trim();
            return String.Compare(url1, url2) == 0;
        }

        public static bool UrlStartsWith(String url1, String url2)
        {
            return url1.StartsWith(url2, StringComparison.OrdinalIgnoreCase);
        }

        public static bool SameConcept(CodeableConcept concept, CodeableConcept concept2)
        {
            foreach (Coding code2 in concept2.Coding)
            {
                if (SameCode(concept, code2) == true)
                    return true;
            }
            return false;
        }

        public static bool SameCode(CodeableConcept concept, Coding code2)
        {
            foreach (Coding code1 in concept.Coding)
            {
                if (SameCode(code1, code2) == true)
                    return true;
            }
            return false;
        }

        public static bool SameCode(Coding code1, Coding code2)
        {
            if (String.Compare(code1.System, code2.System) != 0)
                return false;
            if (String.Compare(code1.Code, code2.Code) != 0)
                return false;
            return true;
        }
    }
}
