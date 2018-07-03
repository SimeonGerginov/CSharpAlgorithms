using System;

namespace Dijkstra
{
    public class Startup
    {
        private const int NumberOfVertices = 9;

        public static void Main()
        {
            var graph = new int[NumberOfVertices, NumberOfVertices] {
                { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
            };

            DijkstraAlgorithm(graph, 0);
        }

        public static int MinIndex(int[] distance, bool[] shortestPathTreeSet)
        {
            var minDistance = int.MaxValue;
            var minIndex = 0;

            for (int v = 0; v < NumberOfVertices; v++)
            {
                if (!shortestPathTreeSet[v] && distance[v] <= minDistance)
                {
                    minDistance = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public static void PrintDistances(int[] distance)
        {
            Console.WriteLine("Vertex   Distance from source");

            for (int i = 0; i < NumberOfVertices; i++)
            {
                Console.WriteLine($"{i}   {distance[i]}");
            }
        }

        public static void DijkstraAlgorithm(int[,] graph, int source)
        {
            var distance = new int[NumberOfVertices];
            var shortestPathTreeSet = new bool[NumberOfVertices];

            for (int i = 0; i < NumberOfVertices; i++)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < NumberOfVertices - 1; count++)
            {
                var minIndex = MinIndex(distance, shortestPathTreeSet);
                shortestPathTreeSet[minIndex] = true;

                for (int v = 0; v < NumberOfVertices; v++)
                {
                    var potentialDistance = distance[minIndex] + graph[minIndex, v];

                    if (!shortestPathTreeSet[v] && 
                        graph[minIndex, v] != 0 &&
                        distance[minIndex] != int.MaxValue &&
                        potentialDistance < distance[v])
                    {
                        distance[v] = potentialDistance;
                    }
                }
            }

            PrintDistances(distance);
        }
    }
}
