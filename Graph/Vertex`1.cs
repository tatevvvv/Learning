namespace Graph
{
    public class Vertex<T>
    {
        private readonly T _element;

        public Vertex(T element)
        {
            _element = element;
        }

        public T GetElement()
        {
            return _element;
        }
    }
}
