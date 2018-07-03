using System;
using System.Collections.Generic;

namespace BreadthFirstSearch
{
    public class Graph
    {
        private int numberOfVertices;
        private int[,] adjacencyMatrix;

        public Graph(int numberOfVertices, int[,] adjacencyMatrix)
        {
            this.numberOfVertices = numberOfVertices;
            this.adjacencyMatrix = adjacencyMatrix;
        }

        public void BreadthFirstSearch(int source)
        {
            var visited = new bool[this.numberOfVertices];
            var queueOfNodes = new Queue<int>();

            visited[source] = true;
            queueOfNodes.Enqueue(source);

            while (queueOfNodes.Count != 0)
            {
                var currentNode = queueOfNodes.Dequeue();
                Console.WriteLine(currentNode);

                for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
                {
                    if (adjacencyMatrix[currentNode, i] == 1 && !visited[i])
                    {
                        queueOfNodes.Enqueue(i);
                        visited[i] = true;
                    }
                }
            }
        }
    }
}
