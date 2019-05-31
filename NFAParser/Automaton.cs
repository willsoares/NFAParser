using System.Collections.Generic;

namespace NFAParser
{
    internal class Automaton
    {
        internal Automaton()
        {
            Nodes = new HashSet<string>();
            FinishNodes = new HashSet<string>();
            Edges = new List<Edge>();
        }
        internal string StartingPoint { get; set; }
        internal HashSet<string> Nodes { get; set; }
        internal HashSet<string> FinishNodes { get; set; }
        internal List<Edge> Edges { get; set; }
    }
}
