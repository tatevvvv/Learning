namespace TestProject
{
    public class SmallestInfiniteSet
    {
        PriorityQueue<int, int> _pq;
        int _currentMin = 1;

        public SmallestInfiniteSet()
        {
            _pq = new PriorityQueue<int, int>(Enumerable.Range(1, 1000).Select(x => (x, x)));
        }

        public int PopSmallest()
        {
            int result;
            if(_pq.Count == 0 )
            {
                result = _currentMin;
                _currentMin++;
            }
            else
            {
                result =_pq.Dequeue();
                while(_pq.Count > 0 && _pq.Peek() == result) 
                {
                    _pq.Dequeue();
                }
            }

            return result;
        }

        public void AddBack(int value)
        {
            _pq.Enqueue(value, value);
        }
    }
}