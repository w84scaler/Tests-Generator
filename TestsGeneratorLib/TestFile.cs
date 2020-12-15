using System;
using System.Collections.Generic;
using System.Text;

namespace TestsGeneratorLib
{
    public class TestFile
    {
        public string Name { get; }
        public string Code { get; }

        internal TestFile(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}