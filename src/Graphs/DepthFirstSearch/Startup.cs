using System;
using System.Collections.Generic;

namespace DepthFirstSearch
{
    public class Startup
    {
        public static void Main()
        {
            var graph = new Dictionary<string, List<string>>
            {
                {"sofiq", new List<string> {"burgas", "varna", "plovdiv", "kyustendil"} },
                {"burgas", new List<string> {"varna", "vidin", "gabrovo"} },
                {"plovdiv", new List<string> {"burgas", "vidin", "gabrovo"} },
                {"gabrovo", new List<string> {"sofiq"} },
                {"kyustendil", new List<string> {"blagoevgrad", "sofiq", "dupnica"} },
                {"varna", new List<string> {"sofiq", "burgas"} },
                {"vidin", new List<string> {"plovdiv", "burgas"} },
                {"dupnica", new List<string> {"kyustendil", "blagoevgrad"} },
                {"blagoevgrad", new List<string> {"sofiq", "kyustendil", "dupnica"} },
            };

            DepthFirstSearch("dupnica", graph);
        }

        public static void DepthFirstSearch(string node, Dictionary<string, List<string>> graph)
        {
            var visited = new HashSet<string>();
            var stackOfNodes = new Stack<string>();

            stackOfNodes.Push(node);
            visited.Add(node);

            while (stackOfNodes.Count != 0)
            {
                var currentNode = stackOfNodes.Pop();
                Console.WriteLine(currentNode);

                for (int i = 0; i < graph[currentNode].Count; i++)
                {
                    if (!visited.Contains(graph[currentNode][i]))
                    {
                        stackOfNodes.Push(graph[currentNode][i]);
                        visited.Add(graph[currentNode][i]);
                    }
                }
            }
        }
    }
}
