using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public static class ValueSetExtensions
    {
        public static Coding Find(this ValueSet vs, String code)
        {
            foreach (ValueSet.ConceptSetComponent component in vs.Compose.Include)
            {
                foreach (ValueSet.ConceptReferenceComponent concept in component.Concept)
                {
                    if (concept.Code == code)
                        return new Coding(component.System, concept.Code, concept.Display);
                }
            }

            throw new Exception($"Code {code} not found in valueset!");
        }

        public static ValueSet Remove(this ValueSet vs, String code)
        {
            foreach (ValueSet.ConceptSetComponent component in vs.Compose.Include)
            {
                foreach (ValueSet.ConceptReferenceComponent concept in component.Concept)
                {
                    if (concept.Code == code)
                    {
                        component.Concept.Remove(concept);
                        return vs;
                    }
                }
            }

            throw new Exception($"Code {code} not found in valueset. Remove failed!");
        }
    }
}