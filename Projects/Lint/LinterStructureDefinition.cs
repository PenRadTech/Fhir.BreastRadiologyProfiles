using Eir.DevTools;
using Eir.FhirKhit.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lint
{
    class LinterStructureDefinition
    {
        private StructureDefinition sDef;
        private Processor processor;
        public LinterStructureDefinition(Processor processor,
            StructureDefinition sDef)
        {
            this.sDef = sDef;
            this.processor = processor;
        }

        public void FindLint()
        {
            if (this.sDef.Snapshot == null)
            {
                SnapshotCreator.Create(this.sDef);
            }
            ElementLoader loader = new ElementLoader(this.processor);
            ElementNode e = loader.Create(sDef);
            SliceCardinalities(this.sDef, e);
        }

        void SliceCardinalities(StructureDefinition sDef,
            ElementNode e)
        {
            ElementDefinition element = e.Element;
            void Check()
            {
                if (e.Slices.Count == 0)
                    return;
                Int32 totalMin = element.Min.Value;
                Int32 totalMax = element.Max.ToMax();

                Debug.Assert(totalMin >= 0);
                Debug.Assert(totalMax >= 0);

                Int32 sliceMin = 0;
                Int32 sliceMax = 0;

                foreach (ElementSlice slice in e.Slices)
                {
                    void Add(ref Int32 value, Int32 diff)
                    {
                        if (value == Int32.MaxValue)
                            return;
                        if (diff == Int32.MaxValue)
                        {
                            value = Int32.MaxValue;
                            return;
                        }

                        value += diff;
                    }

                    Int32 min = slice.ElementNode.Element.Min.Value;
                    Int32 max = slice.ElementNode.Element.Max.ToMax();
                    Add(ref sliceMin, min);
                    if (max == Int32.MaxValue)
                        sliceMax = Int32.MaxValue;
                    else
                        Add(ref sliceMax, max);
                    Debug.Assert(sliceMin >= 0);
                    Debug.Assert(sliceMax >= 0);
                }

                if (sliceMin != totalMin)
                {
                    this.processor.LintMsg(LinkNumbers.SliceMinCheck, sDef.Url, element.Path,
                        $"Invalid Min. Element {totalMin} Slices {sliceMin}");
                }

                if (sliceMax != totalMax)
                {
                    String totalMaxStr = totalMax == Int32.MaxValue ? "*" : totalMax.ToString();
                    String sliceMaxStr = sliceMax == Int32.MaxValue ? "*" : sliceMax.ToString();

                    this.processor.LintMsg(LinkNumbers.SliceMaxCheck, sDef.Url, element.Path,
                        $"Invalid Max. Element {totalMaxStr} Slices {sliceMaxStr}");
                }
            }

            Check();
            foreach (ElementNode child in e.Children)
                SliceCardinalities(sDef, child);
        }
    }
}
