using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TermMerge
{
    class FSHFiles
    {
        Dictionary<String, FSHFile> valueSets = new Dictionary<string, FSHFile>();
        Dictionary<String, FSHFile> codeSystems = new Dictionary<string, FSHFile>();

        List<FSHFile> files = new List<FSHFile>();

        public FSHFiles()
        {
        }

        public bool TryGetCodeSystem(String name, out FSHFile f) => this.codeSystems.TryGetValue(name, out f);

        public void Save()
        {
            foreach (FSHFile f in this.files)
                f.Save();
        }


        public void AddFiles(params String[] inputDirs)
        {
            foreach (String inputDir in inputDirs)
            {
                foreach (String file in Directory.GetFiles(inputDir))
                {
                    FSHFile f = new FSHFile(file);
                    files.Add(f);
                    foreach (String line in f.Lines)
                    {
                        String s = line.Trim();

                        String Name()
                        {
                            int i = s.IndexOf(':');
                            String retVal = s.Substring(i + 1).Trim();
                            i = retVal.IndexOf(' ');
                            if (i > 0)
                                retVal = retVal.Substring(0, i).Trim();
                            return retVal;
                        }
                        if (s.StartsWith("CodeSystem"))
                            codeSystems.Add(Name(), f);
                        else if (s.StartsWith("ValueSet"))
                            valueSets.Add(Name(), f);
                    }
                }
            }
        }
    }
}
