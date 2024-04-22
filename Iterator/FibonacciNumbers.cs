using System.Collections;

namespace Iterator
{
    public class FibonacciNumbers : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new FibonacciIterator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FibonacciIterator();
        }
    }
}
