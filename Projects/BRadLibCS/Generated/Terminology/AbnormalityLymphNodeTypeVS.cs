using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BRadLibCS
{
	public class AbnormalityLymphNodeTypeVS
	{
		/// <summary>
		/// This class creates a type for codings of this class, that implicitly converts to Coding
		/// Allows type checking for these codes.
		/// </summary>
		public class TCoding
		{
		    public Coding Value {get;}
			public static implicit operator Coding(TCoding tCode) => tCode.Value;
			public static implicit operator CodeableConcept(TCoding tCode) => new CodeableConcept(tCode.Value.System, tCode.Value.Code, tCode.Value.Display);

			public TCoding(Coding value)
		    {
		        this.Value= value;
		    }
		}

		/// <summary>
		/// Url of this value set.
		/// </summary>
		public const String Url = "http://hl7.org/fhir/us/breast-radiology/ValueSet/AbnormalityLymphNodeTypeVS";

		public static TCoding Code_NodeAxillary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeAxillary);                                      // CSItemValueSet.cs:72
		public static TCoding Code_NodeEnlarged = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeEnlarged);                                      // CSItemValueSet.cs:72
		public static TCoding Code_NodeFocalCortex = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeFocalCortex);                                // CSItemValueSet.cs:72
		public static TCoding Code_NodeInfraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeInfraclavicular);                        // CSItemValueSet.cs:72
		public static TCoding Code_NodeIntramammary = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeIntramammary);                              // CSItemValueSet.cs:72
		public static TCoding Code_NodeLymph = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymph);                                            // CSItemValueSet.cs:72
		public static TCoding Code_NodeLymphNormal = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeLymphNormal);                                // CSItemValueSet.cs:72
		public static TCoding Code_NodeSupraclavicular = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeSupraclavicular);                        // CSItemValueSet.cs:72
		public static TCoding Code_NodeUniformThickness = new TCoding(AbnormalityLymphNodeTypeCS.Code_NodeUniformThickness);                      // CSItemValueSet.cs:72

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_NodeAxillary;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_NodeEnlarged;                                                                                                       // CSItemValueSet.cs:83
		    yield return Code_NodeFocalCortex;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_NodeInfraclavicular;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_NodeIntramammary;                                                                                                   // CSItemValueSet.cs:83
		    yield return Code_NodeLymph;                                                                                                          // CSItemValueSet.cs:83
		    yield return Code_NodeLymphNormal;                                                                                                    // CSItemValueSet.cs:83
		    yield return Code_NodeSupraclavicular;                                                                                                // CSItemValueSet.cs:83
		    yield return Code_NodeUniformThickness;                                                                                               // CSItemValueSet.cs:83
		}                                                                                                                                         // CSItemValueSet.cs:104
	}
}
