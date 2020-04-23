using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Eir.DevTools;
using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadiology.XUnitTests
{
    public class SDChecker : ConverterBase
    {
        const String fcn = "Check";

        public SDChecker()
        {
        }

        public void Check(ElementDefinition element,
            String name,
            String baseName,
            HashSet<String> ids)
        {
            String id = element.ElementId;

            if (String.IsNullOrEmpty(id))
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"{name}. Empty element id found");
            }

            if (ids.Contains(id))
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"{name}.{id}. Duplicate element id");
            }

            ids.Add(id);

            if (id.StartsWith(baseName) == false)
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"{name}.{id}. Should start with {baseName}");
            }

            if (element.Path.StartsWith(baseName) == false)
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"{name}.{id}. Path should start with {baseName}");
            }

            //if (
            //    (element.Definition == null) ||
            //    (element.Definition.ToString().Length == 0)
            //    )
            //{
            //    this.ConversionError(this.GetType().Name,
            //       fcn,
            //       $"{name}.{id}. Empty definition");
            //}

            if (id.Split('.').Length == 1)
                return;

            if (element.Min.HasValue == false)
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"{name}.{id}. missing min");
            }

            if (String.IsNullOrEmpty(element.Max))
            {
                this.ConversionError(this.GetType().Name,
                    fcn,
                    $"{name}.{id}. missing max");
            }
        }

        public void Check(List<ElementDefinition> elements,
            String name,
            String baseName)
        {
            if (elements == null)
                return;

            HashSet<String> ids = new HashSet<string>();
            foreach (ElementDefinition element in elements)
                this.Check(element, name, baseName, ids);
        }

        public void Check(StructureDefinition.SnapshotComponent snapShot,
            String name,
            String baseName)
        {
            if (snapShot == null)
                return;
            this.Check(snapShot.Element, name, baseName);
        }

        public void Check(StructureDefinition.DifferentialComponent differentialComponent,
            String name,
            String baseName)
        {
            if (differentialComponent == null)
                return;
            this.Check(differentialComponent.Element, name, baseName);
        }

        public void Check(StructureDefinition sd)
        {
            String name = sd.Url.LastUriPart();
            String baseName = sd.BaseDefinition.LastUriPart();
            this.Check(sd.Snapshot, name, baseName);
            this.Check(sd.Differential, name, baseName);
        }

        public void CheckDir(String inputDir, String inputMask)
        {
            foreach (String inputPath in Directory.GetFiles(inputDir, inputMask))
                this.CheckFile(inputPath);
        }

        public void CheckFile(String inputPath)
        {
            String fhirText = File.ReadAllText(inputPath);
            FhirJsonParser parser = new FhirJsonParser();
            var resource = parser.Parse(fhirText, typeof(Resource));
            switch (resource)
            {
                case StructureDefinition sd:
                    this.Check(sd);
                    break;
            }
        }
    }
}