using System;
using System.Collections.Generic;
using System.Text;

namespace BreastRadiology.XUnitTests
{
    class Definition
    {
        StringBuilder sb = new StringBuilder();
        bool eolFlag = true;


        void MakeEOLN()
        {
            if (this.eolFlag == true)
                return;
            this.sb.AppendLine("");
            this.eolFlag = true;
        }

        public Definition CiteStart(String citationSource)
        {
            MakeEOLN();
            this.sb.AppendLine($"[{citationSource}]");
            this.eolFlag = true;
            return this;
        }

        public Definition CiteEnd()
        {
            MakeEOLN();
            //this.sb.AppendLine($"    -- {citationSource}");
            return this;
        }

        public Definition Text(String line)
        {
            this.eolFlag = false;
            this.sb.Append(line);
            return this;
        }

        public Definition Line(String line)
        {
            this.eolFlag = true;
            this.sb.AppendLine(line);
            return this;
        }

        public override string ToString() => this.ToText();

        public String ToText()
        {
            return this.sb.ToString();
        }
    }
}