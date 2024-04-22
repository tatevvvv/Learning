using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal static class DFS
    {
        public int[] dfsSearch(int[] vertices)
        {
            var stack = new Stack<int>();
            var visited = new bool[vertices.Length];

            var start = vertices[0];
            stack.Push(start);

            while (stack.Count > 0)
            {
                var pop = stack.Pop();
                if(!visited.Contains(pop))
                {
                    visited.Add(pop);
                    var adjacent = getAdjacent(pop);
                    foreach(var v in adjacent )
                    {
                        stack.Push(v);
                    }
                }
            }

        }
    }
}
