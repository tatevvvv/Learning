namespace Graph
{
    public class Edge<T>
    {
        private readonly T _value;

        public Edge(T value)
        {
            _value = value;
        }

        public T GetElement() { return _value; }
    }
}
