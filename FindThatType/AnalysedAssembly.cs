using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindThatType
{
    internal class AnalysedAssembly
    {
        internal string Path { get; private set; }
        internal IEnumerable<Type> Types { get; private set; }
        internal AnalysedAssembly(string path, IEnumerable<Type> types)
        {
            Path = path;
            Types = types;
        }
        public override string ToString()
        {
            return Path;
        }
    }
}
