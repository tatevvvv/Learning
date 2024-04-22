namespace DateTimeTypes
{
    internal class AdjacencyMatrixGraph
    {
        private int[][] _matrix;

        private int _count;

        public AdjacencyMatrixGraph(int[] vertices, List<int>[] edges)
        {
            if (vertices.Length != edges.Length)
            {
                throw new ArgumentException(nameof(vertices));
            }
            _count = vertices.Length;

            foreach (var vertex in edges)
            {

            }
        }
    }
}
