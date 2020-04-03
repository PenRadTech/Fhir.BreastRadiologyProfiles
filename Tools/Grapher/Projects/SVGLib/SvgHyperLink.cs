using System;
using System.ComponentModel;

namespace SVGLib
{
	/// <summary>
	/// It represents the group SVG element.
	/// </summary>
	public class SvgHyperLink: SvgElement
	{
		/// <summary>
		/// Target of link.
		/// </summary>
		[Category("(Specific)")]
		[Description("Target")]
		public string Target
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrTarget);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrTarget, value);
		}

		/// <summary>
		/// X-axis coordinate of the side of the element which has the smaller x-axis coordinate value in the current user coordinate system. If the attribute is not specified, the effect is as if a value of 0 were specified.
		/// </summary>
		[Category("(Specific)")]
		[Description("HRef")]
		public string HRef
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrXLink_HRef);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrXLink_HRef, value);
		}

		/// <summary>
		/// It constructs a group element with no attribute.
		/// </summary>
		/// <param name="doc">SVG document.</param>
		public SvgHyperLink(SvgDoc doc):base(doc)
		{
			Init();
		}

		private void Init()
		{
			m_sElementName = "a";
			m_ElementType = _SvgElementType.typeHyperLink;

			AddAttr(SvgAttribute._SvgAttribute.attrXLink_HRef, "");
			AddAttr(SvgAttribute._SvgAttribute.attrTarget, "");
		}
	}
}
