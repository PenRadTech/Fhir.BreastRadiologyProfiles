using System;
using System.ComponentModel;

namespace SVGLib
{
	/// <summary>
	/// It represents the group SVG element.
	/// </summary>
	public class SvgDefs: SvgElement
	{
		/// <summary>
		/// It constructs a group element with no attribute.
		/// </summary>
		/// <param name="doc">SVG document.</param>
		public SvgDefs(SvgDoc doc):base(doc)
		{
			Init();
		}

		private void Init()
		{
			m_sElementName = "defs";
			m_ElementType = _SvgElementType.typeDefs;
		}
	}
}
