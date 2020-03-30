using System;
using System.ComponentModel;

namespace SVGLib
{
	/// <summary>
	/// It represents the group SVG element.
	/// </summary>
	public class SvgMarker: SvgElement
	{
		/// <summary>
		/// </summary>
		[Category("(Specific)")]
		[Description("MarkerWidth")]
		public string MarkerWidth
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrMarkerWidth);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrMarkerWidth, value);
		}

		/// <summary>
		/// </summary>
		[Category("(Specific)")]
		[Description("MarkerHeight")]
		public string MarkerHeight
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrMarkerHeight);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrMarkerHeight, value);
		}

		/// <summary>
		/// </summary>
		[Category("(Specific)")]
		[Description("MarkerUnits")]
		public string MarkerUnits
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrMarkerUnits);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrMarkerUnits, value);
		}

		/// <summary>
		/// </summary>
		[Category("(Specific)")]
		[Description("RefX")]
		public string RefX
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrRefX);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrRefX, value);
		}

		/// <summary>
		/// </summary>
		[Category("(Specific)")]
		[Description("RefY")]
		public string RefY
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrRefY);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrRefY, value);
		}

		/// <summary>
		/// </summary>
		[Category("(Specific)")]
		[Description("Orient")]
		public string Orient
		{
			get => GetAttributeStringValue(SvgAttribute._SvgAttribute.attrOrient);
			set => SetAttributeValue(SvgAttribute._SvgAttribute.attrOrient, value);
		}

		/// <summary>
		/// It constructs a group element with no attribute.
		/// </summary>
		/// <param name="doc">SVG document.</param>
		public SvgMarker(SvgDoc doc):base(doc)
		{
			Init();
		}

		private void Init()
		{
			m_sElementName = "marker";
			m_ElementType = _SvgElementType.typeMarker;

			AddAttr(SvgAttribute._SvgAttribute.attrMarkerWidth, "");
			AddAttr(SvgAttribute._SvgAttribute.attrMarkerHeight, "");
			AddAttr(SvgAttribute._SvgAttribute.attrMarkerUnits, "");
			AddAttr(SvgAttribute._SvgAttribute.attrRefX, "");
			AddAttr(SvgAttribute._SvgAttribute.attrRefY, "");
			AddAttr(SvgAttribute._SvgAttribute.attrOrient, "");
		}
	}
}
