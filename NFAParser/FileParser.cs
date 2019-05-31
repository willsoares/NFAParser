using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NFAParser
{
    internal class FileParser
    {
        internal Automaton ParseAutomatonFile(string automatonFile)
        {
            var automaton = new Automaton();
            var lines = File.ReadLines(automatonFile);
            foreach (var line in lines)
            {
                if (line.StartsWith('_'))
                {
                    var nodeName = line.Split('_')[1].Split(":")[0];
                    automaton.Nodes.Add(nodeName);
                    automaton.FinishNodes.Add(nodeName);
                }
                else
                {
                    var nodeLine = line.Split(':');
                    var nodeName = nodeLine[0];
                    automaton.Nodes.Add(nodeName);
                    foreach (var n in nodeLine[1].Split(';'))
                    {
                        if (n != "")
                        {
                            var d = n.Split(',')[0].Trim().Replace("(", string.Empty);
                            var av = n.Split(',')[1].Trim().Replace(")", string.Empty);

                            automaton.Edges.Add(new Edge
                            {
                                Origin = nodeName,
                                Destination = d,
                                AcceptedValue = int.TryParse(av, out int i) ? i : (int?)null
                            });
                        }
                    }
                }
            }
            return automaton;
        }

        internal List<string> ParseWordsFile(string wordsFile)
        {
            return File.ReadLines(wordsFile).ToList();
        }
    }
}
