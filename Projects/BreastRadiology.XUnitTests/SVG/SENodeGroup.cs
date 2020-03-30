using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    [DebuggerDisplay("{this.Title} [{this.nodes.Count}/{this.children.Count}]")]
    public class SENodeGroup
    {
        /// <summary>
        /// For debugging only.
        /// </summary>
        public bool ShowCardinalities
        {
            get
            {
                if (this.showCardinalities == true)
                    return this.showCardinalities;

                foreach (SENodeGroup child in this.Children)
                {
                    if (child.ShowCardinalities == true)
                        return true;
                }

                return false;
            }
            set { this.showCardinalities = value; }
        }

        bool showCardinalities = true;

        /// <summary>
        /// For debugging only.
        /// </summary>
        public String Title { get; set; }

        public IEnumerable<SENode> Nodes => this.nodes;
        List<SENode> nodes = new List<SENode>();

        public IEnumerable<SENodeGroup> Children => this.children;
        List<SENodeGroup> children = new List<SENodeGroup>();

        public SENodeGroup(String title, bool showCardinalities)
        {
            //Debug.Assert(showCardinalities == true);
            this.ShowCardinalities = showCardinalities;
            if (title == null)
                throw new Exception("Title must be non empty for sorting");
            this.Title = title;
        }

        /// <summary>
        /// Sorts the nodes and groups, and calls sort on each child node.
        /// </summary>
        public void Sort()
        {
            this.nodes.Sort((a, b) => a.AllText().CompareTo(b.AllText()));
            this.children.Sort((a, b) => a.Title.CompareTo(b.Title));
            foreach (SENodeGroup child in this.children)
                child.Sort();
        }

        public void AppendNode(SENode node)
        {
            this.nodes.Add(node);
        }

        public void AppendNodes(IEnumerable<SENode> nodes)
        {
            foreach (SENode node in nodes)
                this.AppendNode(node);
        }

        public void AppendChild(SENodeGroup nodeGroup)
        {
            this.children.Add(nodeGroup);
        }

        public SENodeGroup AppendChild(String title, bool showCardinality)
        {
            SENodeGroup retVal = new SENodeGroup(title, showCardinality);
            this.children.Add(retVal);
            return retVal;
        }
    }
}