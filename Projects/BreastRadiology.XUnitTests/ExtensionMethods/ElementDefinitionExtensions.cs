using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public static class ElementDefinitionExtensions
    {
        public static ElementDefinition DefaultValueExtension(this ElementDefinition e, Element defVal)
        {
            e.Extension.Add(new Extension
            {
                Url = Global.DefaultValueExtensionUrl,
                Value = defVal
            });
            return e;
        }
    }
}