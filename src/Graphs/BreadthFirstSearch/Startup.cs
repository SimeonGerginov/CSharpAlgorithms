namespace BreadthFirstSearch
{
    public class Startup
    {
        public static void Main()
        {
            var numberOfVertices = 6;
            var matrix = new int[,]
            {
                { 0, 1, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 0, 1 },
                { 0, 0, 0, 1, 0, 0 },
                { 0, 1, 0, 0, 0, 1 },
                { 1, 0, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0 }
            };

            var graph = new Graph(numberOfVertices, matrix);
            graph.BreadthFirstSearch(0);
        }
    }
}
