using System;
using System.Collections.Generic;
using System.Text;

namespace NFAParser
{
    internal class Edge
    {
        internal string Origin { get; set; }
        internal string Destination { get; set; }
        internal int? AcceptedValue { get; set; }
    }
}
