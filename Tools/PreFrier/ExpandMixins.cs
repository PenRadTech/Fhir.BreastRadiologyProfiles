using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PreFrier
{
    class ExpandMixins
    {
        class MixinInfo
        {
            public List<String> InputLines;
            public List<String> OutputLines;
            public String Path;
        };

        private Dictionary<String, MixinInfo> mixins = new Dictionary<string, MixinInfo>();

        bool IsMixin(String[] lines, out String name)
        {
            name = null;
            Int32 i = 0;
            String firstLine = null;
            while (i < lines.Length)
            {
                firstLine = lines[i].Trim();
                if (firstLine.StartsWith("RuleSet:") == true)
                    break;
                i += 1;
            }

            if (i >= lines.Length)
                return false;

            name = firstLine.Substring(8).Trim();
            Int32 spaceIndex = name.IndexOf(" ");
            if (spaceIndex > 0)
                name = name.Substring(0, spaceIndex);
            return true;
        }

        public void AddMixinDir(String dir)
        {
            Console.WriteLine($"note Expanding mixins in {dir}");
            foreach (String fileName in Directory.GetFiles(dir, "*.fsh"))
            {
                String[] lines = File.ReadAllLines(fileName);
                if (IsMixin(lines, out String mixinName))
                {
                    MixinInfo info = new MixinInfo
                    {
                        InputLines = lines.ToList(),
                        Path = fileName
                    };
                    mixins.Add(mixinName, info);
                }
            }
        }

        String Mixins(MixinInfo info, List<String> lines, ref Int32 i)
        {
            String retVal = null;
            while (i < info.InputLines.Count)
            {
                String line = info.InputLines[i++];
                retVal = line.Trim().Replace(" ", "");
                lines.Add(line);
                if (retVal.StartsWith("//+Mixins:"))
                    return retVal;
            }

            return null;
        }

        bool SkipTo(List<String> lines, String text, ref Int32 i)
        {
            while (i < lines.Count)
            {
                String line = lines[i++];
                String s = line.Trim().Replace(" ", "");
                if (s.StartsWith(text))
                    return true;
            }

            return false;
        }

        void AddMixin(List<String> lines, 
            String mixinName)
        {
            if (this.mixins.TryGetValue(mixinName, out MixinInfo info) == false)
                throw new Exception($"Mixin {mixinName} not found");
            Process(info);
            Int32 i = 0;
            if (SkipTo(info.OutputLines, "RuleSet:", ref i) == false)
                throw new Exception("Cant find RuleSet in fsh file");
            Int32 j = i;
            if (SkipTo(info.OutputLines, "//-Mixins:", ref j) == true)
                i = j;
            while (i < info.OutputLines.Count)
                lines.Add(info.OutputLines[i++]);
        }

        void Process(MixinInfo info)
        {
            // already processed?
            if (info.OutputLines != null)
                return;

            List<String> lines = new List<string>();
            Int32 i = 0;


            while (i < info.InputLines.Count)
            {
                String s = Mixins(info, lines, ref i);
                if (s == null)
                    break;
                if (SkipTo(info.InputLines, "//-Mixins:", ref i) == false)
                    throw new Exception("Cant find terminator '//-Mixins'");
                s = s.Substring(s.IndexOf(':') + 1);
                String[] mixins = s.Split(',');
                foreach (String mixin in mixins)
                    AddMixin(lines, mixin);
                lines.Add("  //- Mixins:");
            }

            info.OutputLines = lines;
        }

        public void Process()
        {
            String Text(IEnumerable<String> lines)
            {
                StringBuilder sb = new StringBuilder();
                foreach (String line in lines)
                    sb.AppendLine(line);
                return sb.ToString();
            }

            foreach (MixinInfo info in this.mixins.Values)
                this.Process(info);

            foreach (MixinInfo info in this.mixins.Values)
            {
                String inputText = Text(info.InputLines);
                String outputText = Text(info.OutputLines);
                if (String.Compare(inputText, outputText) != 0)
                {
                    Console.WriteLine($"note Modifying {info.Path}");
                    File.WriteAllLines(info.Path, info.OutputLines);
                }
            }
        }
    }
}
