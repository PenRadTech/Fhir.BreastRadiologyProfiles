using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grapher
{
    public static class ElementDefinitionExtensions
    {
        public static IEnumerable<ElementDefinition> ExtensionSlices(
            this IEnumerable<ElementDefinition> items)
        {
            bool IsExtension(ElementDefinition item)
            {
                if (item.Type.Count < 1)
                    return false;
                if (item.Type[0].Code != "Extension")
                    return false;
                if (String.IsNullOrEmpty(item.SliceName))
                    return false;
                if (item.Type[0].Profile.Count() != 1)
                    return false;
                return true;
            }

            foreach (ElementDefinition item in items)
            {
                if (IsExtension(item))
                {
                    yield return item;
                }
            }
        }
    }
}
