using FhirKhit.Tools;
using FhirKhit.Tools.R4;
using Hl7.Fhir.Specification.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PreFhir;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Model;
using System.Collections.Generic;
using BreastRadiology.XUnitTests;
using System.Drawing;
using ExcelDataReader;
using System.Data;
using System.Globalization;
using BreastRadiology.Shared;
using ClosedXML.Excel;
using Svg;
using System.Drawing.Imaging;
using System.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using Hl7.Fhir.Specification.Snapshot;

namespace BreastRadiology.XUnitTests
{
    [TestClass]
    public sealed class BuildFragments : IDisposable
    {
        const String BaseDirName = "BreastRadiologyProfiles";

        String BaseDir
        {
            get
            {
                if (this.baseDirFull == null)
                    this.baseDirFull = DirHelper.FindParentDir(BaseDirName);
                return this.baseDirFull;
            }
        }

        String baseDirFull;

        String cacheDir;
        String contentDir;
        String guideDir;

        String graphicsDir;
        String fragmentsDir;
        String resourcesDir;
        String pageDir;
        String pageTemplateDir;
        String mergedDir;
        String includesDir;
        String examplesDir;

        String acrFragmentsDir;
        String acrResourcesDir;
        String acrGraphicsDir;
        String acrPageDir;
        String acrExamplesDir;

        FileCleaner fc = null;

        public void Dispose()
        {
            this.fc?.Dispose();
        }

        public BuildFragments()
        {
            String MkDir(params String[] paths)
            {
                String retVal = Path.Combine(paths);
                if (Directory.Exists(retVal) == false)
                    Directory.CreateDirectory(retVal);
                return retVal;
            }

            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Encoding enc1252 = CodePagesEncodingProvider.Instance.GetEncoding(1252);

            this.cacheDir = MkDir(this.BaseDir, "Cache");
            this.contentDir = MkDir(this.BaseDir, "IG", "Content");
            this.guideDir = MkDir(this.BaseDir, "IG", "Guide");

            this.graphicsDir = MkDir(this.contentDir, "Graphics");
            this.fragmentsDir = MkDir(this.contentDir, "Fragments");
            this.resourcesDir = MkDir(this.contentDir, "Resources");
            this.pageDir = MkDir(this.contentDir, "Page");
            this.pageTemplateDir = MkDir(this.contentDir, "PageTemplate");
            this.includesDir = MkDir(this.contentDir, "Includes");
            this.examplesDir = MkDir(this.contentDir, "Examples");

            this.mergedDir = MkDir(this.contentDir, "Merged");

            this.acrFragmentsDir = MkDir(this.contentDir, "ACR", "Fragments");
            this.acrResourcesDir = MkDir(this.contentDir, "ACR", "Resources");
            this.acrPageDir = MkDir(this.contentDir, "ACR", "Page");
            this.acrGraphicsDir = MkDir(this.contentDir, "ACR", "Graphics");
            this.acrExamplesDir = MkDir(this.contentDir, "ACR", "Examples");
        }

        private void Message(String import, string className, string method, string msg)
        {
            Trace.WriteLine($"[{import}] {className}.{method}: {msg}");
        }

        private bool StatusWarnings(string className, string method, string msg)
        {
            if (msg.Contains(" does not resolve", new System.StringComparison()))
                return true;

            this.Message("Warn", className, method, msg);
            return true;
        }

        private bool StatusInfo(string className, string method, string msg)
        {
            //if (msg.Contains(" does not resolve", new System.StringComparison()))
            //    return true;

            //if (msg.Contains("http://www.fragment.com", new System.StringComparison()))
            //    return true;

            //if (msg.Contains("Unknown Code System", new System.StringComparison()))
            //    return true;

            //this.Message("Info", className, method, msg);
            return true;
        }

        private bool StatusErrors(string className, string method, string msg)
        {
            this.Message("Error", className, method, msg);
            return true;
        }

        [TestMethod]
        public void B1_BuildFragments()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting B1_BuildFragments");
            try
            {
                ResourcesMaker pc = new ResourcesMaker(this.fc, this.fragmentsDir, this.pageDir, this.cacheDir);
                pc.StatusErrors += this.StatusErrors;
                pc.StatusInfo += this.StatusInfo;
                pc.StatusWarnings += this.StatusWarnings;
                pc.CreateResources();
                ResourcesMaker.UniqueCitations.Sort();
                if (pc.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    pc.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending B1_BuildFragments [{(Int32)span.TotalSeconds}]");
        }

        [TestMethod]
        public void B2_BuildResources()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting B2_BuildResources");
            bool saveMergedFiles = false;

            try
            {
                if (saveMergedFiles == false)
                {
                    if (Directory.Exists(this.mergedDir) == true)
                        Directory.Delete(this.mergedDir, true);
                }

                PreFhirGenerator preFhir = new PreFhirGenerator(this.fc, this.cacheDir);
                preFhir.StatusErrors += this.StatusErrors;
                preFhir.StatusInfo += this.StatusInfo;
                preFhir.StatusWarnings += this.StatusWarnings;
                preFhir.AddDir(this.fragmentsDir, "*.json");
                if (saveMergedFiles)
                    preFhir.MergedDir = this.mergedDir;
                preFhir.BreakOnElementId = "";
                preFhir.BreakOnTitle = "";
                preFhir.Process();
                preFhir.SaveResources(this.resourcesDir);

                if (preFhir.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    preFhir.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending B2_BuildResources [{(Int32)span.TotalSeconds}]");
        }

        [TestMethod]
        public void B3_PatchIntroDocs()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting B3_PatchIntroDocs");
            try
            {
                ResourceMap map = new ResourceMap();
                map.AddDir(this.resourcesDir, "*.json");

                IntroDocPatcher docPatcher = new IntroDocPatcher(this.pageDir);
                docPatcher.StatusErrors += this.StatusErrors;
                docPatcher.StatusInfo += this.StatusInfo;
                docPatcher.StatusWarnings += this.StatusWarnings;
                docPatcher.AddResourceDir(this.resourcesDir);
                docPatcher.AddFragDir(this.fragmentsDir);
                docPatcher.Patch();
                if (docPatcher.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    docPatcher.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending B3_PatchIntroDocs [{(Int32)span.TotalSeconds}]");
        }

        [TestMethod]
        public void B4_BuildGraphics()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting B4_BuildGraphics");
            try
            {
                {
                    ResourceMap map = new ResourceMap();
                    map.AddDir(this.resourcesDir, "*.json");
                    {
                        FocusMapMaker focusMapMaker = new FocusMapMaker(this.fc, 
                            map, 
                            this.graphicsDir, 
                            this.pageDir);
                        focusMapMaker.Create();
                    }
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.AlwaysShowChildren = true;
                        // resourceMapMaker.SvgEditor.RenderTestPoint = "Tumor Satellite";
                        String svgPath = Path.Combine(this.graphicsDir, "TotalProfile.svg");
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("BreastRadComposition"),
                            svgPath);

                        // Create PNG Image from SVG-File
                        //var svgDoc = Svg.SvgDocument.Open(svgPath);
                        //svgDoc.AspectRatio = new SvgAspectRatio();
                        //svgDoc.ShapeRendering = SvgShapeRendering.Auto;

                        //String pngPath = Path.Combine(this.graphicsDir, "TotalProfile.png");
                        //Int32 dpi = 1;
                        //Int32 width = 2748 * dpi;
                        //Int32 height = 38028 * dpi;

                        //Bitmap bmp = svgDoc.Draw(width, height);
                        //bmp.Save(pngPath, ImageFormat.Png);
                    }
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("BreastRadComposition"),
                            Path.Combine(this.graphicsDir, "ProfileOverview.svg"));
                    }
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("MGFinding"),
                            Path.Combine(this.graphicsDir, "MgFindings.svg"));
                    }
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("MRIFinding"),
                            Path.Combine(this.graphicsDir, "MRIFindings.svg"));
                    }
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("NMFinding"),
                            Path.Combine(this.graphicsDir, "NMFindings.svg"));
                    }
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("USFinding"),
                            Path.Combine(this.graphicsDir, "USFindings.svg"));
                    }
                }

                {
                    ResourceMap map = new ResourceMap();
                    map.AddDir(this.fragmentsDir, "*.json");

                    FragmentMapMaker fragmentMapMaker = new FragmentMapMaker(this.fc, 
                        map, 
                        this.graphicsDir,
                        this.pageTemplateDir);
                    fragmentMapMaker.Create(true);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending B4_BuildGraphics [{(Int32)span.TotalSeconds}]");
        }

        [TestMethod]
        public void B5_BuildExamples()
        {
        }


        [TestMethod]
        public void B6_BuildIG()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting B5_BuildIG");
            try
            {
                String outputDir = Path.Combine(this.guideDir, "input");

                IGBuilder p = new IGBuilder(outputDir);
                p.StatusErrors += this.StatusErrors;
                p.StatusInfo += this.StatusInfo;
                p.StatusWarnings += this.StatusWarnings;
                p.Start(Path.Combine(this.contentDir, "IGBreastRad.xml"));

                p.AddGrouping($"{ResourcesMaker.Group_BaseResources}", "Main Resources",
                    "This section contains the main top level resources that are used in a Breast Radiology Report.");

                p.AddGrouping($"{ResourcesMaker.Group_CommonResources}", "Common Resources",
                    "This section contains resources that are commonly used throughout a Breast Radiology Report");
                p.AddGrouping($"{ResourcesMaker.Group_CommonCodesVS}", "Common ValueSets ",
                    "This section contains value sets that are commonly used throughout a Breast Radiology Report");
                p.AddGrouping($"{ResourcesMaker.Group_CommonCodesCS}", "Common CodeSystems",
                    "This section contains code systems that are commonly used throughout a Breast Radiology Report");

                p.AddGrouping($"{ResourcesMaker.Group_MGResources}", "Mammography Resources",
                    "This section contains resources used specifically in a Mammography exam");
                p.AddGrouping($"{ResourcesMaker.Group_MGCodesVS}", "Mammography ValueSets",
                    "This section contains value sets used specifically in a Mammography exam");
                p.AddGrouping($"{ResourcesMaker.Group_MGCodesCS}", "Mammography CodeSystems",
                    "This section contains code systems used specifically in a Mammography exam");

                p.AddGrouping($"{ResourcesMaker.Group_MRIResources}", "MRI Resources",
                    "This section contains resources used specifically in a MRI exam");
                p.AddGrouping($"{ResourcesMaker.Group_MRICodesVS}", "MRI ValueSets",
                    "This section contains value sets used specifically in a MRI exam");
                p.AddGrouping($"{ResourcesMaker.Group_MRICodesCS}", "MRI CodeSystems",
                    "This section contains code systems used specifically in a MRI exam");

                p.AddGrouping($"{ResourcesMaker.Group_USResources}", "Ultra-Sound Resources",
                    "This section contains resources used specifically in a Ultra-Sound exam");
                p.AddGrouping($"{ResourcesMaker.Group_USCodesVS}", "Ultra-Sound ValueSets",
                    "This section contains value sets used specifically in a Ultra-Sound exam");
                p.AddGrouping($"{ResourcesMaker.Group_USCodesCS}", "Ultra-Sound CodeSystems",
                    "This section contains code systems used specifically in a Ultra-Sound exam");

                p.AddGrouping($"{ResourcesMaker.Group_NMResources}", "Nuclear Medicine Resources",
                    "This section contains resources used specifically in a Nuclear Medicine exam");
                p.AddGrouping($"{ResourcesMaker.Group_NMCodesVS}", "Nuclear Medicine ValueSets",
                    "This section contains value sets used specifically in a Nuclear Medicine exam");
                p.AddGrouping($"{ResourcesMaker.Group_NMCodesCS}", "Nuclear Medicine CodeSystems",
                    "This section contains code systems used specifically in a Nuclear Medicine exam");

                p.AddGrouping($"{ResourcesMaker.Group_AimResources}", "AIM Resources",
                    "This section contains resources used specifically by AIM");
                p.AddGrouping($"{ResourcesMaker.Group_AimCodesVS}", "AIM ValueSets",
                    "This section contains value sets used specifically by AIM");
                p.AddGrouping($"{ResourcesMaker.Group_AimCodesCS}", "AIM CodeSystems",
                    "This section contains code systems used specifically by AIM");

                p.AddGrouping($"{ResourcesMaker.Group_Fragments}", "Fragments",
                    "This section the fragments that are used to define the resources");

                p.AddGrouping($"{ResourcesMaker.Group_ExtensionResources}", "Extension",
                    "Extension Resource Definitions");

                p.AddGrouping($"{ResourcesMaker.Group_Examples}", "Examples",
                    "Example Definitions");

                p.AddResources(this.resourcesDir);
                p.AddResources(this.acrResourcesDir);

                p.AddFragments(this.fragmentsDir);
                p.AddFragments(this.acrFragmentsDir);

                p.AddPageContent(this.pageDir);
                p.AddPageContent(this.acrPageDir);
                p.AddPageContent(this.pageTemplateDir);
                p.AddIncludes(this.includesDir);
                p.AddExamples(this.examplesDir);
                p.AddImages(this.graphicsDir);
                p.AddImages(this.acrGraphicsDir);
                p.SaveAll();

                //if (p.HasErrors)
                //{
                //    StringBuilder sb = new StringBuilder();
                //    p.FormatErrorMessages(sb);
                //    Trace.WriteLine(sb.ToString());
                //    Debug.Assert(false);
                //}
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending B6_BuildIG[{(Int32)span.TotalSeconds}]");
        }

        [TestMethod]
        public void B7_RunPublisher()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting B7_RunPublisher");
            try
            {
                String executingDir = Path.Combine(DirHelper.FindParentDir("BreastRadiologyProfiles"),
                    "IG",
                    "guide");
                String jarPath = Path.Combine(executingDir, "input-cache", "org.hl7.fhir.publisher.jar");
                String igPath = Path.Combine(executingDir, "ig.ini");
                if (File.Exists(jarPath) == false)
                    throw new Exception($"Missing publisher jar '{jarPath}'");

                IGPublisher p = new IGPublisher();
                p.StatusErrors += this.StatusErrors;
                p.StatusInfo += this.StatusInfo;
                p.StatusWarnings += this.StatusWarnings;
                p.Publish(executingDir, jarPath, igPath);

                if (p.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    p.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Assert.IsTrue(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending B7_RunPublisher[{(Int32)span.TotalSeconds}]");
        }


        [TestMethod]
        public void A1_Build()
        {
            using (this.fc = new FileCleaner())
            {
                this.fc?.Add(this.graphicsDir, "*.svg");
                this.fc?.Add(this.pageDir, "*.xml");
                this.fc?.Add(this.fragmentsDir, "*.json");
                this.fc?.Add(this.resourcesDir, "*.json");

                this.C1_Build();

                this.B1_BuildFragments();
                this.B2_BuildResources();
                this.B3_PatchIntroDocs();
                this.B4_BuildGraphics();
                this.B5_BuildExamples();
                this.B6_BuildIG();
            }
        }

        [TestMethod]
        public void A2_BuildAndPublish()
        {
            this.A1_Build();
            this.B7_RunPublisher();
        }

        [TestMethod]
        public void A3_BuildExamplesAndPublish()
        {
            this.B5_BuildExamples();
            this.B6_BuildIG();
            this.B7_RunPublisher();
        }

        [TestMethod]
        public void Z_ValidateOutputResources()
        {
            String rDir = Path.Combine(this.guideDir,
                "input",
                "resources");
            FhirValidator fv = new FhirValidator();
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;

            bool success = fv.ValidateDir(rDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            //fv.FormatMessages(sb);
            //Trace.WriteLine(sb.ToString());
            Assert.IsTrue(success);
            Assert.IsTrue(fv.HasErrors == false);
            Trace.WriteLine("Validation complete");
        }

        [TestMethod]
        public void Z_SDCheckInputResources()
        {
            SDChecker fv = new SDChecker();
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            fv.CheckDir(this.resourcesDir, "*.json");
        }

        [TestMethod]
        public void F_ValidateExamples()
        {
            FhirValidator fv = new FhirValidator(Path.Combine(this.cacheDir, "validation.xml"));
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            fv.ValidatorArgs = $" -ig {resourcesDir} ";
            // C:\Development\HL7\BreastRadiologyProfiles\IG\Guide\input
            bool success = fv.ValidateDir(this.examplesDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            fv.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void G_ValidateAcrExamples()
        {
            FhirValidator fv = new FhirValidator(Path.Combine(this.cacheDir, "validation.xml"));
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            fv.ValidatorArgs = $" -ig {resourcesDir} -ig {acrResourcesDir}";
            // C:\Development\HL7\BreastRadiologyProfiles\IG\Guide\input
            bool success = fv.ValidateDir(this.acrExamplesDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            fv.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Z_ValidateInputResources()
        {
            FhirValidator fv = new FhirValidator(Path.Combine(this.cacheDir, "validation.xml"));
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            bool success = fv.ValidateDir(this.resourcesDir, "*.json", "4.0.0");
            //StringBuilder sb = new StringBuilder();
            //fv.FormatMessages(sb);
            //Trace.WriteLine(sb.ToString());
            //Assert.IsTrue(success);
            Trace.WriteLine("Validation complete");
        }


        [TestMethod]
        public void Z_BuildSpreadSheetOfItems()
        {
            DataTable dt;

            DataTable CreateTable()
            {
                DataTable retVal = new DataTable("Pages");
                retVal.Columns.Add(new DataColumn("Checked", typeof(Boolean)));
                retVal.Columns.Add(new DataColumn("Link", typeof(String)));
                retVal.Columns.Add(new DataColumn("Notes", typeof(String)));
                return retVal;
            }

            void Add(String path, String filter)
            {
                foreach (String file in Directory.GetFiles(path, filter))
                {
                    String fileName = Path.GetFileNameWithoutExtension(file);
                    dt.Rows.Add(
                        new object[]
                        {
                            null,
                            $"http://build.fhir.org/ig/HL7/fhir-breast-radiology-ig/{fileName}.html",
                            null
                        });
                }
            }

            void AddBlank()
            {
                dt.Rows.Add(new object[] { null, null, null });
            }

            dt = CreateTable();

            String resourcesDir = Path.Combine(
                DirHelper.FindParentDir("BreastRadiologyProfiles"),
                "IG",
                "Content",
                "Resources"
            );
            Add(resourcesDir, "StructureDefinition-*.json");
            AddBlank();
            AddBlank();
            AddBlank();
            Add(resourcesDir, "CodeSystem-*.json");
            AddBlank();
            AddBlank();
            AddBlank();
            Add(resourcesDir, "ValueSet-*.json");
            String savePath = @"c:\Temp\BreastRadPages.xlsx";

            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet sheet = workbook.Worksheets.Add(dt);
            sheet.Columns().AdjustToContents();
            sheet.Columns().Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Border.TopBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Border.RightBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            sheet.Columns().Style.Alignment.WrapText = true;
            sheet.Columns().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            sheet.Columns().Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            File.Delete(savePath);
            workbook.SaveAs(savePath);
        }

        [TestMethod]
        public void C1_Build()
        {
            this.D1_BuildACRFragments();
            this.D2_BuildAcrResources();
            this.D3_PatchIntroDocs();
            this.D4_BuildGraphics();
        }

        [TestMethod]
        public void D1_BuildACRFragments()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting D1_BuildAcrFragments");
            try
            {
                ResourcesMaker pc = new ResourcesMaker(this.fc,
                    this.acrFragmentsDir,
                    this.acrPageDir,
                    this.cacheDir);
                pc.StatusErrors += this.StatusErrors;
                pc.StatusInfo += this.StatusInfo;
                pc.StatusWarnings += this.StatusWarnings;
                pc.CreateAcrResources();
                if (pc.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    pc.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending D1_BuildAcrFragments [{(Int32)span.TotalSeconds}]");
        }


        [TestMethod]
        public void D2_BuildAcrResources()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting D2_BuildAcrResources");
            bool saveMergedFiles = false;

            try
            {
                if (saveMergedFiles == false)
                {
                    if (Directory.Exists(this.mergedDir) == true)
                        Directory.Delete(this.mergedDir, true);
                }

                PreFhirGenerator preFhir = new PreFhirGenerator(this.fc, this.cacheDir);
                preFhir.StatusErrors += this.StatusErrors;
                preFhir.StatusInfo += this.StatusInfo;
                preFhir.StatusWarnings += this.StatusWarnings;
                preFhir.AddDir(this.acrFragmentsDir, "*.json");
                if (saveMergedFiles)
                    preFhir.MergedDir = this.mergedDir;
                preFhir.BreakOnElementId = "";
                preFhir.BreakOnTitle = "";
                preFhir.Process();
                preFhir.SaveResources(this.acrResourcesDir);

                if (preFhir.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    preFhir.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending D2_BuildAcrResources [{(Int32)span.TotalSeconds}]");
        }



        [TestMethod]
        public void D3_PatchIntroDocs()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting D3_PatchIntroDocs");
            try
            {
                ResourceMap map = new ResourceMap();
                map.AddDir(this.resourcesDir, "*.json");

                IntroDocPatcher docPatcher = new IntroDocPatcher(this.acrPageDir);
                docPatcher.StatusErrors += this.StatusErrors;
                docPatcher.StatusInfo += this.StatusInfo;
                docPatcher.StatusWarnings += this.StatusWarnings;
                docPatcher.AddResourceDir(this.acrResourcesDir);
                docPatcher.AddFragDir(this.acrFragmentsDir);
                docPatcher.Patch();
                if (docPatcher.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    docPatcher.FormatErrorMessages(sb);
                    Trace.WriteLine(sb.ToString());
                    Debug.Assert(false);
                }
            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending D3_PatchIntroDocs [{(Int32)span.TotalSeconds}]");
        }



        [TestMethod]
        public void D4_BuildGraphics()
        {
            DateTime start = DateTime.Now;
            Trace.WriteLine("Starting D4_BuildGraphics");
            try
            {
                {
                    ResourceMap map = new ResourceMap();
                    map.AddDir(this.acrResourcesDir, "*.json");
                    {
                        ResourceMapMaker resourceMapMaker = new ResourceMapMaker(this.fc, map);
                        resourceMapMaker.AlwaysShowChildren = true;
                        resourceMapMaker.Create(ResourcesMaker.CreateUrl("ImagingContextExtension"),
                            Path.Combine(this.acrGraphicsDir, "ImagingContextOverview.svg"));
                    }
                    {
                        FocusMapMaker focusMapMaker = new FocusMapMaker(this.fc,
                            map,
                            this.acrGraphicsDir,
                            this.acrPageDir);
                        focusMapMaker.Create();
                    }
                }

                {
                    ResourceMap map = new ResourceMap();
                    map.AddDir(this.acrFragmentsDir, "*.json");

                    FragmentMapMaker fragmentMapMaker = new FragmentMapMaker(this.fc,
                        map,
                        this.acrGraphicsDir,
                        this.pageTemplateDir);
                    fragmentMapMaker.Create(false);
                }

            }
            catch (Exception err)
            {
                Trace.WriteLine(err.Message);
                Assert.IsTrue(false);
            }

            TimeSpan span = DateTime.Now - start;
            Trace.WriteLine($"Ending D4_BuildGraphics [{(Int32)span.TotalSeconds}]");
        }


        [TestMethod]
        public void D5_ValidateAcr()
        {
            // 
            IGBuilder.RemoveFragmentExtensions(this.acrResourcesDir);
            FhirValidator fv = new FhirValidator(Path.Combine(this.cacheDir, "validation.xml"));
            fv.StatusErrors += this.StatusErrors;
            fv.StatusInfo += this.StatusInfo;
            fv.StatusWarnings += this.StatusWarnings;
            bool success = fv.ValidateDir(this.acrResourcesDir, "*.json", "4.0.0");
            StringBuilder sb = new StringBuilder();
            fv.FilterMessages("not resolve");
            fv.FormatMessages(sb);
            Trace.WriteLine(sb.ToString());
            Assert.IsTrue(success);
            Trace.WriteLine("Validation complete");
        }
    }
}