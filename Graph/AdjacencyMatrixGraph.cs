namespace Graph
{
    internal class AdjacencyMatrixGraph<TVertex, TEdge> : IGraph<TVertex, TEdge>
    {
        private const int _defaultCapacity = 10;

        private Tuple<TVertex, TVertex, TEdge>[,] _adjacencyMatrix;
        private int _numVertices;

        public AdjacencyMatrixGraph()
        {
            _adjacencyMatrix = new Tuple<TVertex, TVertex, TEdge>[_defaultCapacity, _defaultCapacity];
            _numVertices = 0;
        }

        public IEnumerable<Edge<TEdge>> Edges()
        {
            throw new NotImplementedException();
        }

        public Edge<TEdge> GetEdge(Vertex<TVertex> v, Vertex<TVertex> u)
        {
            throw new NotImplementedException();
        }

        public void InsertEdge(Vertex<TVertex> v, Vertex<TVertex> u, TEdge e)
        {
            throw new NotImplementedException();
        }

        public void InsertVertex(TVertex x)
        {
            if (_numVertices == _defaultCapacity)
            {
                throw new OutOfMemoryException();
            }

            _numVertices++;
        }

        public int NumEdges()
        {
            throw new NotImplementedException();
        }

        public int NumVertices()
        {
            throw new NotImplementedException();
        }

        public void RemoveEdge(Edge<TEdge> e)
        {
            throw new NotImplementedException();
        }

        public void RemoveVertex(TVertex x)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vertex<TVertex>> Vertices()
        {
            throw new NotImplementedException();
        }
    }
}
