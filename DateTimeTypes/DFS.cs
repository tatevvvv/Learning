namespace DateTimeTypes
{
    internal static class DFS
    {
        public static HashSet<int> Traverse(Graph graph)
        {
            var visited = new HashSet<int>();
            var stack = new Stack<int>();

            stack.Push(0);
            while (stack.Count > 0)
            {
                var curr = stack.Pop();
                if (visited.Contains(curr))
                {
                    return visited;
                }

                visited.Add(curr);

                var adj = graph.AdjacentList[curr];
                if (adj != null)
                {
                    foreach (var v in adj)
                    {
                        stack.Push(adj.First());
                    }
                }
            }

            return visited;
        }
    }
}
