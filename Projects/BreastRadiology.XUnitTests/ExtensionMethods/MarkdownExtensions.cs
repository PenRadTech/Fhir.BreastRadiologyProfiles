using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    public static class MarkdownExtensions
    {
        /// <summary>
        /// Preformatted markdown
        /// </summary>
        /// <returns></returns>
        public static Markdown BlockQuote(this Markdown md, params string[] lines)
        {
            foreach (String line in lines)
                md.Value += $"{line}\n";
            return md;
        }

        public static Markdown List(this Markdown md, ValueSet vs)
        {
            List<String> items = new List<string>();
            foreach (ValueSet.ConceptSetComponent component in vs.Compose.Include)
            {
                foreach (ValueSet.ConceptReferenceComponent concept in component.Concept)
                    items.Add($"{concept.Code} - {concept.Display}");
            }

            return md.List(items.ToArray());
        }

        public static Markdown Refinement(this Markdown md, ValueSet vs, String name)
        {
            md
                .Paragraph($"The type of this {name} may be further refined by one of the following values:")
                .List(vs)
                ;
            return md;
        }

        public static Markdown ValidModalities(this Markdown md,
            Modalities modalities)
        {
            //List<String> s = new List<string>();

            //void Add(Modalities flag)
            //{
            //    if ((modalities & flag) == flag)
            //        s.Add($" {flag.ToString()}");
            //}

            //md.Paragraph("Valid for the following modalities:");
            //Add(Modalities.MG);
            //Add(Modalities.US);
            //Add(Modalities.MRI);
            //Add(Modalities.NM);
            //md.List(s.ToArray());
            return md;
        }
    }
}