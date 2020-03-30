using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public class PatternSlice
    {
        public String SliceName { get; }
        public String ShortDefinition { get; }
        public Markdown Definition { get; }
        public Element Pattern { get; }
        public Int32 Min { get; }
        public String Max { get; }

        public PatternSlice(String sliceName,
            String shortStr,
            Markdown definition,
            Element pattern,
            Int32 min,
            String max)
        {
            this.SliceName = sliceName;
            this.ShortDefinition = shortStr;
            this.Definition = definition;
            this.Pattern = pattern;
            this.Min = min;
            this.Max = max;
        }
    }
}