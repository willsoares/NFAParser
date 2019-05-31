using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFAParser
{
    static class AutomatonExtensions
    {
        public static Dictionary<string, LinkedList<(string destination, int? value)>> ToAdjacencyList(this Automaton automaton)
        {
            var adjacencyList = new Dictionary<string, LinkedList<(string destination, int? value)>>();
            foreach (var n in automaton.Nodes)
            {
                adjacencyList.Add(n, new LinkedList<(string destination, int? value)>());
                var edges = automaton.Edges.Where(e => e.Origin == n);
                foreach(var e in edges)
                {
                    adjacencyList[n].AddLast((e.Destination, e.AcceptedValue));
                }
            }
            return adjacencyList;
        }
    }
}
