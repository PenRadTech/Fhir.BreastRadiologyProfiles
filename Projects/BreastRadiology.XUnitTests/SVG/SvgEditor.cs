using SVGLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class SvgEditor
    {
        class EndPoint
        {
            public PointF Location { get; set; }
            public String Annotation { get; set; }
        }

        const String ArrowStart = "arrowStart";
        const String ArrowEnd = "arrowEnd";

        const float ArrowEndSize = 0.5f;
        SvgDoc doc;
        SvgRoot root;

        //public String RenderTestPoint;
        public float BorderWidth { get; set; } = 0.125f;
        public float LineHeight { get; set; } = 1.25f;
        public float BorderMargin { get; set; } = 0.5f;
        public float NodeGapNoCardStartX { get; set; } = 2.0f;
        public float NodeGapCardStartX { get; set; } = 3.0f;
        public float NodeGapNoCardEndX { get; set; } = 2.0f;
        public float NodeGapCardEndX { get; set; } = 3.0f;
        public float NodeGapY { get; set; } = 0.5f;
        public float RectRx { get; set; } = 0.25f;
        public float RectRy { get; set; } = 0.25f;

        String ToPx(float value) => $"{15 * value}";

        float screenX = -1;
        float screenY = -1;

        float maxWidth = 0;
        float maxHeight = 0;

        public SvgEditor()
        {
            this.doc = new SvgDoc();
            this.root = this.doc.CreateNewDocument();
            this.CreateArrowStart();
            this.CreateArrowEnd();
        }

        void CreateArrowEnd()
        {
            SvgMarker arrowEnd = this.doc.AddMarker();
            arrowEnd.RefX = $"{this.ToPx(ArrowEndSize)}";
            arrowEnd.RefY = $"{this.ToPx(ArrowEndSize / 2)}";
            arrowEnd.MarkerWidth = $"{this.ToPx(ArrowEndSize)}";
            arrowEnd.MarkerHeight = $"{this.ToPx(ArrowEndSize)}";
            arrowEnd.MarkerUnits = "px";
            arrowEnd.Id = ArrowEnd;

            SvgPolygon p = this.doc.AddPolygon(arrowEnd);
            p.Points = $"0 0 {this.ToPx(ArrowEndSize)} {this.ToPx(ArrowEndSize / 2)} 0 {this.ToPx(ArrowEndSize)}";
            p.StrokeWidth = "0";
            p.Fill = Color.Black;
            p.StrokeWidth = "0";
        }

        void CreateArrowStart()
        {
            float radius = 0.125f;

            SvgMarker arrowStart = this.doc.AddMarker();
            arrowStart.RefX = $"{this.ToPx(radius)}";
            arrowStart.RefY = $"{this.ToPx(radius)}";
            arrowStart.MarkerWidth = $"{this.ToPx(2 * radius)}";
            arrowStart.MarkerHeight = $"{this.ToPx(2 * radius)}";
            arrowStart.MarkerUnits = "px";
            arrowStart.Id = ArrowStart;

            SvgCircle c = this.doc.AddCircle(arrowStart);
            c.CX = $"{this.ToPx(radius)}";
            c.CY = $"{this.ToPx(radius)}";
            c.R = $"{this.ToPx(radius)}";
            c.Fill = Color.Black;
            c.StrokeWidth = "0";
        }


        public float NodeGapEndX(SENodeGroup g)
        {
            if (g.ShowCardinalities == true)
                return this.NodeGapCardEndX;
            return this.NodeGapNoCardEndX;
        }

        public float NodeGapStartX(SENodeGroup g)
        {
            if (g.ShowCardinalities == true)
                return this.NodeGapCardStartX;
            return this.NodeGapNoCardStartX;
        }

        public void Render(SENodeGroup group,
            bool lineFlag)
        {
            if (this.screenX == -1)
                this.screenX = this.BorderMargin;
            if (this.screenY == -1)
                this.screenY = this.BorderMargin;

            List<EndPoint> endConnectors = new List<EndPoint>();

            this.RenderGroup(group, this.screenX, this.screenY, lineFlag, out float width, out float height,
                endConnectors);
            this.root.Width = $"{this.ToPx(this.maxWidth + this.NodeGapStartX(group) + this.NodeGapEndX(group))}";
            this.root.Height = $"{this.ToPx(this.maxHeight + 2 * this.NodeGapY)}";
            this.screenY = this.maxHeight + 4 * this.BorderMargin;
        }

        void CreateArrow(SvgGroup g,
            bool startMarker,
            bool endMarker,
            float xStart,
            float yStart,
            float xEnd,
            float yEnd)
        {
            SvgLine stub = this.doc.AddLine(g);
            stub.Stroke = Color.Black;
            stub.X1 = this.ToPx(xStart);
            stub.X2 = this.ToPx(xEnd);
            stub.Y1 = this.ToPx(yStart);
            stub.Y2 = this.ToPx(yEnd);
            stub.StrokeWidth = this.ToPx(this.BorderWidth);
            if (startMarker)
                stub.MarkerStart = $"url(#{ArrowStart})";
            if (endMarker)
                stub.MarkerEnd = $"url(#{ArrowEnd})";
        }

        void CreateLine(SvgGroup g, float x1, float y1, float x2, float y2)
        {
            SvgLine stub = this.doc.AddLine(g);
            stub.Stroke = Color.Black;
            stub.X1 = this.ToPx(x1);
            stub.X2 = this.ToPx(x2);
            stub.Y1 = this.ToPx(y1);
            stub.Y2 = this.ToPx(y2);
            stub.StrokeWidth = this.ToPx(this.BorderWidth);
        }

        void RenderGroup(SENodeGroup group,
            float screenX,
            float screenY,
            bool lineFlag,
            out float colWidth,
            out float colHeight,
            List<EndPoint> endConnectors)
        {
            colWidth = 0;
            colHeight = 0;

            if (group.Nodes.Count() > 0)
                this.RenderSimpleGroup(group, screenX, screenY, lineFlag, out colWidth, out colHeight, endConnectors);
            else if (group.Children.Count() > 0)
            {
                foreach (SENodeGroup childGroup in group.Children)
                {
                    this.RenderGroup(childGroup, screenX, screenY, lineFlag, out float tColWidth, out float tColHeight,
                        endConnectors);
                    colHeight += tColHeight;
                    screenY += tColHeight;
                    if (colWidth < tColWidth)
                        colWidth = tColWidth;
                }
            }
        }

        void RenderSimpleGroup(SENodeGroup group,
            float screenX,
            float screenY,
            bool lineFlag,
            out float colWidth,
            out float colHeight,
            List<EndPoint> endConnectors)
        {
            colWidth = 0;
            colHeight = 0;

            SvgGroup g = this.doc.AddGroup(null);
            float col1ScreenX = screenX;
            float col1ScreenY = screenY;
            float col1Width = 0;
            float col1Height = 0;

            float topConnectorY = float.MaxValue;
            float bottomConnectorY = float.MinValue;

            List<EndPoint> startConnectors = new List<EndPoint>();

            foreach (SENode node in group.Nodes)
            {
                this.Render(g, node, screenX, col1ScreenY, out float nodeWidth, out float nodeHeight);
                if (col1Width < nodeWidth)
                    col1Width = nodeWidth;

                float connectorY = col1ScreenY + nodeHeight / 2;
                if (topConnectorY > connectorY)
                    topConnectorY = connectorY;
                if (bottomConnectorY < connectorY)
                    bottomConnectorY = connectorY;
                startConnectors.Add(new EndPoint
                {
                    Location = new PointF(screenX + nodeWidth, col1ScreenY + nodeHeight / 2),
                    Annotation = node.OutgoingAnnotation
                });

                endConnectors.Add(new EndPoint
                {
                    Location = new PointF(screenX, col1ScreenY + nodeHeight / 2),
                    Annotation = node.IncomingAnnotation
                });
                col1Height += nodeHeight + this.NodeGapY;
                col1ScreenY += nodeHeight + this.NodeGapY;
            }

            if (this.maxWidth < col1ScreenX + col1Width)
                this.maxWidth = col1ScreenX + col1Width;
            if (this.maxHeight < col1ScreenY)
                this.maxHeight = col1ScreenY;

            float col2ScreenX = screenX + col1Width + this.NodeGapStartX(group) + this.NodeGapEndX(group);
            float col2ScreenY = screenY;

            float col2Height = 0;
            bool endConnectorFlag = false;
            foreach (SENodeGroup child in group.Children)
            {
                List<EndPoint> col2EndConnectors = new List<EndPoint>();

                this.RenderGroup(child,
                    col2ScreenX,
                    col2ScreenY,
                    lineFlag,
                    out float col2GroupWidth,
                    out float col2GroupHeight,
                    col2EndConnectors);
                col2ScreenY += col2GroupHeight;
                col2Height += col2GroupHeight;

                if ((lineFlag) && (startConnectors.Count > 0))
                {
                    for (Int32 i = 0; i < col2EndConnectors.Count; i++)
                    {
                        EndPoint stubEnd = col2EndConnectors[i];
                        endConnectorFlag = true;
                        float xStart = screenX + col1Width + this.NodeGapStartX(group);
                        this.CreateArrow(g, false, true, xStart, stubEnd.Location.Y, stubEnd.Location.X,
                            stubEnd.Location.Y);

                        if (child.ShowCardinalities == true)
                        {
                            SvgText t = this.doc.AddText(g);
                            t.X = this.ToPx(xStart + 0.25f);
                            t.Y = this.ToPx(stubEnd.Location.Y - 0.25f);
                            t.TextAnchor = "left";
                            t.Value = stubEnd.Annotation;
                        }

                        if (topConnectorY > stubEnd.Location.Y)
                            topConnectorY = stubEnd.Location.Y;
                        if (bottomConnectorY < stubEnd.Location.Y)
                            bottomConnectorY = stubEnd.Location.Y;
                    }
                }

                float width = col1Width + this.NodeGapStartX(group) + this.NodeGapEndX(group) + col2GroupWidth;
                if (colWidth < width)
                    colWidth = width;

                if (this.maxWidth < col2ScreenX + col2GroupWidth)
                    this.maxWidth = col2ScreenX + col2GroupWidth;
            }

            if ((lineFlag) && (endConnectorFlag == true))
            {
                foreach (EndPoint stubStart in startConnectors)
                {
                    this.CreateArrow(g, true, false, stubStart.Location.X, stubStart.Location.Y,
                        screenX + col1Width + this.NodeGapStartX(group), stubStart.Location.Y);

                    if (group.ShowCardinalities == true)
                    {
                        SvgText t = this.doc.AddText(g);
                        t.X = this.ToPx(stubStart.Location.X + 0.25f);
                        t.Y = this.ToPx(stubStart.Location.Y - 0.25f);
                        t.TextAnchor = "left";
                        t.Value = stubStart.Annotation;
                    }
                }

                // Make vertical line that connects all stubs.
                if (group.Children.Count() > 0)
                {
                    float x = screenX + col1Width + this.NodeGapStartX(group);
                    this.CreateLine(g, x, topConnectorY, x, bottomConnectorY);
                }
            }

            if (this.maxHeight < col2ScreenY)
                this.maxHeight = col2ScreenY;

            if (colHeight < col1Height)
                colHeight = col1Height;
            if (colHeight < col2Height)
                colHeight = col2Height;
        }

        void Render(SvgGroup parentGroup,
            SENode node,
            float screenX,
            float screenY,
            out float width,
            out float height)
        {
            const float CharMod = 0.7f;

            //Debug.Assert((this.RenderTestPoint == null) || node.AllText().Contains(RenderTestPoint) == false);
            height = node.TextLines.Count * this.LineHeight + 2 * this.BorderMargin;
            width = node.Width * CharMod + 2 * this.BorderMargin;

            SvgGroup g = this.doc.AddGroup(parentGroup);
            g.Transform = $"translate({this.ToPx(screenX)} {this.ToPx(screenY)})";
            SvgRect square;

            if (node.HRef != null)
            {
                SvgHyperLink l = this.doc.AddHyperLink(g);
                l.Target = "_top";
                l.HRef = node.HRef.ToString();
                square = this.doc.AddRect(l);
            }
            else
            {
                square = this.doc.AddRect(g);
            }

            square.Stroke = Color.Black;
            square.StrokeWidth = this.ToPx(this.BorderWidth);
            square.RX = this.ToPx(this.RectRx);
            square.RY = this.ToPx(this.RectRy);
            square.X = "0";
            square.Y = "0";
            square.Width = this.ToPx(width);
            square.Height = this.ToPx(height);
            square.Fill = node.FillColor;

            float textX = this.BorderMargin;
            float textY = this.BorderMargin + 1;

            foreach (SEText line in node.TextLines)
            {
                SvgText t;
                if (line.HRef != null)
                {
                    SvgHyperLink l = this.doc.AddHyperLink(g);
                    l.HRef = line.HRef;
                    l.Target = "_top";
                    if (line.Title != null)
                    {
                        SvgTitle title = this.doc.AddTitle(l);
                        title.Value = line.Title;
                    }

                    t = this.doc.AddText(l);
                }
                else
                {
                    t = this.doc.AddText(g);
                }

                t.X = this.ToPx(width / 2);
                t.Y = this.ToPx(textY);
                t.TextAnchor = "middle";
                t.Value = line.Text;

                textY += this.LineHeight;
            }
        }

        public String GetXml()
        {
            return this.doc.GetXML();
        }

        public void Save(String path)
        {
            this.doc.SaveToFile(path);
        }
    }
}