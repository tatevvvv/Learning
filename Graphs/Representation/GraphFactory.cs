using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs.Representation
{
    internal class GraphFactory
    {
        private LinkedList<int>[] _graph;

        public static LinkedList<int>[] CreateGraphAsAdjacentList(int[] vertices, List<Tuple<int, int>> edges)
        {
            // todo: some validations

            var result = new LinkedList<int>[vertices.Length];

            for (int i = 0; i < vertices.Length; ++i)
            {
                var connectedVertexes = edges.Where(e => e.Item1 == vertices[i]).Select(e => e.Item2).ToList();
                result[i] = new LinkedList<int>(connectedVertexes);
            }

            return result;
        }

        public void AddVertex(int vertex)
        {

        }
    }
}
