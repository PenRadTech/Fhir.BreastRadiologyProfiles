// --------------------------------------------------------------------------------
// Name:     SvgTitle
//
// Author:   Maurizio Bigoloni <big71@fastwebnet.it>
//           See the ReleaseNote.txt file for copyright and license information.
//
// Remarks:
//
// --------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Drawing;

namespace SVGLib
{
	/// <summary>
	/// It represents the text SVG element.
	/// </summary>
	public class SvgTitle : SvgElement
	{
		/// <summary>
		/// This attribute assigns a (CSS) class name or set of class names to an element.
		/// </summary>
		[Category("Style")]
		[Description("This attribute assigns a (CSS) class name or set of class names to an element.")]
		public string Class
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrStyle_Class);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrStyle_Class, value);
		}

		/// <summary>
		/// This attribute specifies style information for the current element. The style attribute specifies style information for a single element.
		/// </summary>
		[Category("Style")]
		[Description("This attribute specifies style information for the current element. The style attribute specifies style information for a single element.")]
		public string Style
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrStyle_Style);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrStyle_Style, value);
		}

		/// <summary>
		/// The value of the element.
		/// </summary>
		[Category("(Specific)")]
		[Description("The value of the element.")]
		public string Value
		{
			get => m_sElementValue;
			set => m_sElementValue = value;
		}


		/// <summary>
		/// It constructs a text element with no attribute.
		/// </summary>
		/// <param name="doc">SVG document.</param>
		public SvgTitle(SvgDoc doc):base(doc)
		{
			m_sElementName = "title";
			m_bHasValue = true;
			m_ElementType = _SvgElementType.typeText;

			AddAttr(SvgAttribute._SvgAttribute.attrStyle_Class, "");
			AddAttr(SvgAttribute._SvgAttribute.attrStyle_Style, "");
		}
	}
}
