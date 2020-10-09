using System;
using System.Collections.Generic;
using System.IO;
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
    }
}
