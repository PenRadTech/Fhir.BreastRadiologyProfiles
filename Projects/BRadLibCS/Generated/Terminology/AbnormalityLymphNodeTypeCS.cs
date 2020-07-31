using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AbnormalityLymphNodeTypeCS
	{
		/// <summary>
		/// Code Set System.
		/// </summary>
		public const String System = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS";

		public static Coding Code_NodeAxillary = new Coding(System, "NodeAxillary", "Node axillary");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_NodeEnlarged = new Coding(System, "NodeEnlarged", "Node enlarged");                                             // CSItemCodeSystem.cs:55
		public static Coding Code_NodeFocalCortex = new Coding(System, "NodeFocalCortex", "Node focal cortex");                                   // CSItemCodeSystem.cs:55
		public static Coding Code_NodeInfraclavicular = new Coding(System, "NodeInfraclavicular", "Node infraclavicular");                        // CSItemCodeSystem.cs:55
		public static Coding Code_NodeIntramammary = new Coding(System, "NodeIntramammary", "Node intramammary");                                 // CSItemCodeSystem.cs:55
		public static Coding Code_NodeLymph = new Coding(System, "NodeLymph", "Node lymph");                                                      // CSItemCodeSystem.cs:55
		public static Coding Code_NodeLymphNormal = new Coding(System, "NodeLymphNormal", "Node lymph normal");                                   // CSItemCodeSystem.cs:55
		public static Coding Code_NodeSupraclavicular = new Coding(System, "NodeSupraclavicular", "Node supraclavicular");                        // CSItemCodeSystem.cs:55
		public static Coding Code_NodeUniformThickness = new Coding(System, "NodeUniformThickness", "Node uniform thickness");                    // CSItemCodeSystem.cs:55

		public static IEnumerable<Coding> Codes()                                                                                                 // CSItemCodeSystem.cs:47
		{                                                                                                                                         // CSItemCodeSystem.cs:48
		    yield return Code_NodeAxillary;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_NodeEnlarged;                                                                                                       // CSItemCodeSystem.cs:58
		    yield return Code_NodeFocalCortex;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_NodeInfraclavicular;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_NodeIntramammary;                                                                                                   // CSItemCodeSystem.cs:58
		    yield return Code_NodeLymph;                                                                                                          // CSItemCodeSystem.cs:58
		    yield return Code_NodeLymphNormal;                                                                                                    // CSItemCodeSystem.cs:58
		    yield return Code_NodeSupraclavicular;                                                                                                // CSItemCodeSystem.cs:58
		    yield return Code_NodeUniformThickness;                                                                                               // CSItemCodeSystem.cs:58
		}                                                                                                                                         // CSItemCodeSystem.cs:63
	}
}
