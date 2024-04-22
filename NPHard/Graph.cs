using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPHard
{
    internal class Graph
    {
        private readonly Dictionary<Tuple<int, int>, int> _edges;

        public int numberOfverteces { get; }

        public Graph(int n)
        {
            numberOfverteces = n;
            _edges = new Dictionary<Tuple<int, int>, int>();
        }

        public void AddEdge(int from, int to, int weight)
        {
            var edge = Tuple.Create(from, to);
            _edges[edge] = weight;
            var reverseEdge = Tuple.Create(to, from);
            _edges[reverseEdge] = weight;
        }

        public int GetEdgeWeight(int from, int to)
        {
            var edge = Tuple.Create(from, to);
            return _edges.TryGetValue(edge, out int weight) ? weight : int.MaxValue;
        }
    }
}
