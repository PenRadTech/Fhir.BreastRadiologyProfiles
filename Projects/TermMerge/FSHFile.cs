using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace TermMerge
{
    class FSHFile
    {
        public String Path;
        public List<String> Lines;

        public FSHFile(String path)
        {
            this.Path = path;
            this.Lines = new List<string>(File.ReadAllLines(path));
        }

        public void Save()
        {
            File.WriteAllLines(this.Path, this.Lines);
        }

        String Name(String s)
        {
            int i = s.IndexOf(':');
            String retVal = s.Substring(i + 1).Trim();
            i = retVal.IndexOf(' ');
            if (i > 0)
                retVal = retVal.Substring(0, i).Trim();
            return retVal;
        }

        public Int32 FindCodeSystem(String codeSystem, String concept)
        {
            Int32 retVal = 0;
            while (retVal < this.Lines.Count)
            {
                String line = Lines[retVal].Trim();
                if ((line.StartsWith("CodeSystem")) && (String.Compare(codeSystem, Name(line)) == 0))
                    return retVal;
                retVal += 1;
            }

            return -1;
        }

        public Int32 FindConcept(String codeSystem, String concept)
        {
            Int32 retVal = FindCodeSystem(codeSystem, concept);
            if (retVal < 0)
                return retVal;
            retVal += 1;

            bool Header()
            {
                String line = this.Lines[retVal];
                if (line.IndexOf(':') > 0)
                    return true;
                return false;
            }

            bool Concept()
            {
                String line = this.Lines[retVal];
                Int32 i = line.IndexOf('*');
                if (i < 0)
                    return false;
                line = line.Substring(i+1).Trim();
                if (line[0] != '#')
                    return false;
                line = line.Substring(1);
                i = line.IndexOf(' ');
                if (i < 0)
                    Console.WriteLine("Badly formated line {line}");
                line = line.Substring(0, i);
                if (String.Compare(line.ToUpper(), concept.ToUpper()) == 0)
                    return true;
                return false;
            }

            while ((retVal < this.Lines.Count) && (Header()))
                retVal += 1;

            while (retVal < this.Lines.Count)
            {
                if (Header())
                    return -1;
                if (Concept())
                    return retVal;
                retVal += 1;
            }

            return -1;
        }
    }
}
