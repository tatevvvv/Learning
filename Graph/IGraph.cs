namespace Graph
{
    public interface IGraph<TVertex, TEdge>
    {
        int NumVertices();

        int NumEdges();

        IEnumerable<Vertex<TVertex>> Vertices();

        IEnumerable<Edge<TEdge>> Edges();

        Edge<TEdge> GetEdge(Vertex<TVertex> v, Vertex<TVertex> u);

        void InsertVertex(TVertex x);

        void InsertEdge(Vertex<TVertex> v, Vertex<TVertex> u, TEdge e);

        void RemoveVertex(TVertex x);

        void RemoveEdge(Edge<TEdge> e);
    }
}