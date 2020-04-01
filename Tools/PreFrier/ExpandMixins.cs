using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PreFrier
{
    class ExpandMixins
    {
        struct MixinInfo
        {
            public String[] Lines;
            public String Path;
        };

        private Dictionary<String, MixinInfo> mixins = new Dictionary<string, MixinInfo>();

        String FirstNonCommentLine(String[] lines)
        {
            foreach (String line in lines)
            {
                String s = line.Trim();
                if (s.StartsWith("//") == false)
                    return s;
            }
            return null;
        }

        bool IsMixin(String[] lines, out String name)
        {
            name = null;
            String firstLine = FirstNonCommentLine(lines);
            if (firstLine == null)
                return false;
            if (firstLine.StartsWith("RuleSet:") == false)
                return false;
            name = firstLine.Substring(8).Trim();
            Int32 spaceIndex = name.IndexOf(" ");
            if (spaceIndex > 0)
                name = name.Substring(0, spaceIndex);
            return true;
        }

        public void AddMixinDir(String dir)
        {
            foreach (String fileName in Directory.GetFiles(dir, "*.fsh"))
            {
                String[] lines = File.ReadAllLines(fileName);
                if (IsMixin(lines, out String mixinName))
                {
                    MixinInfo info = new MixinInfo
                    {
                        Lines = lines,
                        Path = fileName
                    };
                    mixins.Add(mixinName, info);
                }
            }
        }

        void Process(MixinInfo info)
        {
            List<String> lines = new List<string>();
            Int32 i = 0;

            String Mixins()
            {
                String retVal = null;
                while (i < info.Lines.Length)
                {
                    String line = info.Lines[i++];
                    retVal = line.Trim().Replace(" ", "");
                    if (retVal.StartsWith("//+Mixins:"))
                        return retVal;
                    lines.Add(line);
                }

                return null;
            }

            void SkipToMixinEnd()
            {
                while (i < info.Lines.Length)
                {
                    String line = info.Lines[i++];
                    String s = line.Trim().Replace(" ", "");
                    if (s.StartsWith("//Mixins:"))
                        return;
                    lines.Add(line);
                }
                throw new Exception("Mixin terminator not found");
            }

            void AddMixin(String mixin)
            {

            }

            while (i < info.Lines.Length)
            {
                String s = Mixins();
                if (s == null)
                    break;
                String[] mixins = s.Split(',');
                foreach (String mixin in mixins)
                    AddMixin(mixin);
                lines.Add("  //- Mixins:");
                SkipToMixinEnd();
            }
            File.WriteAllLines(info.Path, lines);
        }

        public void Process()
        {
            foreach (MixinInfo info in this.mixins.Values)
                this.Process(info);
        }
    }
}
