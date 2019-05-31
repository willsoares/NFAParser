using System;

namespace NFAParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var automatonFile = @"C:\Users\wills\source\repos\AFNParser\AFNParser\automato.txt";
            var wordsFile = @"C:\Users\wills\source\repos\AFNParser\AFNParser\palavras.txt";

            var fileParser = new FileParser();

            var automaton = fileParser.ParseAutomatonFile(automatonFile);
            var words = fileParser.ParseWordsFile(wordsFile);

            var adjacencyList = automaton.ToAdjacencyList();
        }
    }
}
