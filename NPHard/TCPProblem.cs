using NPHard;

class TravelingSalesman
{
    static void Main()
    {
        Graph graph = new(6);

        // adding only one direction edges, since addEdge works for undirected raph, and will add the reverse edge as well
        graph.AddEdge(0, 1, 8);
        graph.AddEdge(0, 2, 11);
        graph.AddEdge(0, 3, 7);
        graph.AddEdge(0, 4, 8);
        graph.AddEdge(0, 5, 9);
        graph.AddEdge(1, 2, 11);
        graph.AddEdge(1, 3, 7);
        graph.AddEdge(1, 4, 12);
        graph.AddEdge(1, 5, 6);
        graph.AddEdge(2, 3, 6);
        graph.AddEdge(2, 4, 9);
        graph.AddEdge(2, 5, 10);
        graph.AddEdge(3, 4, 10);
        graph.AddEdge(3, 5, 8);
        graph.AddEdge(4, 5, 12);


        var startVertex = 0;
        var optinalSolution = CalculateOPtimalSolution(graph, startVertex);
        var optimalWight = CalculateTourDistance(graph, optinalSolution);

        Console.WriteLine($"Optimal solution weight is {optimalWight}");
        Console.WriteLine("Optimal solution  is ");

        foreach (var vertex in optinalSolution)
        {
            Console.Write((char)('a' + vertex) + " ");
        }
    }

    private static IEnumerable<IEnumerable<int>> GetPermutations(IEnumerable<int> list)
    {
        if (!list.Any()) return new List<IEnumerable<int>> { list };
        return list.SelectMany((e, i) =>
            GetPermutations(list.Where((_, index) => index != i))
            .Select(c => (new[] { e }).Concat(c)));
    }

    private static int CalculateTourDistance(Graph graph, int[] tour)
    {
        var distance = 0;
        for (int i = 0; i < tour.Length - 1; i++)
        {
            distance += graph.GetEdgeWeight(tour[i], tour[i + 1]);
        }
        return distance;
    }

    private static int[] CalculateOPtimalSolution(Graph graph, int startVertex)
    {
        var verteces = Enumerable.Range(0, graph.numberOfverteces).Where(c => c != startVertex);
        var permutations = GetPermutations(verteces).Select(p => (new[] { startVertex }).Concat(p));

        return permutations
            .Select(p => p.Append(startVertex))
            .OrderBy(p => CalculateTourDistance(graph, p.ToArray()))
            .First()
            .ToArray();
    }
}
