namespace Trees
{
    public abstract class AbstractPriorityQueue<K, V> : IPriorityQueue<K, V>
    {
        private Comparer<K> comp;

        protected AbstractPriorityQueue(Comparer<K> c)
        {
            this.comp = c;
        }

        public KeyValuePair<K, V> Insert(K key, V value)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<K, V> Min()
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<K, V> RemoveMin()
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}
