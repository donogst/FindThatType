
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindThatType
{
    internal class Hit
    {
        internal string Path { get; private set; }
        internal Type Type { get; private set; }
        public Hit(string path, Type type)
        {
            Path = path;
            Type = type;
        }
        public override string ToString()
        {
            return string.Format("{0} : {1}", Type, Path);
        }
    }
}
