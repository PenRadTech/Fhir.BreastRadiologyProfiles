using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
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

		public static TCoding Code_NodeAxillary = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeAxillary"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeEnlarged = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeEnlarged"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeFocalCortex = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeFocalCortex"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeInfraclavicular = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeInfraclavicular"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeIntramammary = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeIntramammary"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeLymph = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeLymph"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeLymphNormal = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeLymphNormal"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeSupraclavicular = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeSupraclavicular"));// CSItemValueSet.cs:66
		public static TCoding Code_NodeUniformThickness = new TCoding(new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/AbnormalityLymphNodeTypeCS", "NodeUniformThickness"));// CSItemValueSet.cs:66

		public static IEnumerable<TCoding> Codes()                                                                                                // CSItemValueSet.cs:57
		{                                                                                                                                         // CSItemValueSet.cs:58
		    yield return Code_NodeAxillary;                                                                                                       // CSItemValueSet.cs:69
		    yield return Code_NodeEnlarged;                                                                                                       // CSItemValueSet.cs:69
		    yield return Code_NodeFocalCortex;                                                                                                    // CSItemValueSet.cs:69
		    yield return Code_NodeInfraclavicular;                                                                                                // CSItemValueSet.cs:69
		    yield return Code_NodeIntramammary;                                                                                                   // CSItemValueSet.cs:69
		    yield return Code_NodeLymph;                                                                                                          // CSItemValueSet.cs:69
		    yield return Code_NodeLymphNormal;                                                                                                    // CSItemValueSet.cs:69
		    yield return Code_NodeSupraclavicular;                                                                                                // CSItemValueSet.cs:69
		    yield return Code_NodeUniformThickness;                                                                                               // CSItemValueSet.cs:69
		}                                                                                                                                         // CSItemValueSet.cs:92
	}
}
