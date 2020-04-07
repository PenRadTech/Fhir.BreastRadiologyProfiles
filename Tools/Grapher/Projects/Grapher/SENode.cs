using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Grapher
{
    [DebuggerDisplay("{AllText()}{Annotations()}")]
    public class SENode
    {
        private float width;
        public List<SEText> TextLines { get; set; } = new List<SEText>();
        public Color FillColor { get; set; }
        public String HRef { get; set; }

        public float Width
        {
            get => this.width;
            set => this.width = value;
        }

        /// <summary>
        /// Annotation on the line coming into the node (at line end);
        /// </summary>
        public String IncomingAnnotation { get; set; }

        /// <summary>
        /// Annotation on the line leaving the node (at start of outgoing line);
        /// </summary>
        public String OutgoingAnnotation { get; set; }

        public SENode(float width,
            Color fillColor,
            String[] annotations,
            String hRef = null)
        {
            this.Width = width;
            this.FillColor = fillColor;
            if (annotations != null)
            {
                if ((annotations.Length > 0) && (annotations[0] != null))
                    this.IncomingAnnotation = annotations[0];
                if ((annotations.Length > 1) && (annotations[1] != null))
                    this.OutgoingAnnotation = annotations[1];
            }

            this.HRef = hRef;
        }

        public SENode()
        {
        }

        public String Annotations()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-");
            if (String.IsNullOrEmpty(this.IncomingAnnotation) == false)
                sb.Append(this.IncomingAnnotation);
            sb.Append("-");
            if (String.IsNullOrEmpty(this.OutgoingAnnotation) == false)
                sb.Append(this.OutgoingAnnotation);

            return sb.ToString();
        }

        public String AllText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SEText t in this.TextLines)
                sb.Append($"{t.Text} ");
            return sb.ToString();
        }

        public SENode AddTextLine(SEText text)
        {
            if (this.Width < text.Text.Length)
                this.Width = text.Text.Length;
            this.TextLines.Add(text);
            return this;
        }

        public SENode AddTextLine(String text, String hRef = null, String title = null)
        {
            return this.AddTextLine(new SEText(text, hRef, title));
        }
    }
}