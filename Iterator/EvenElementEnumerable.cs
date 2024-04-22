using System.Collections;

namespace Iterator
{
    public class EvenElementEnumerable : IEnumerable<int>
    {
        private int[] _array;
        public EvenElementEnumerable(int[] array)
        {
            _array = array;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new EvenElementEnumerator(_array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EvenElementEnumerator(_array);
        }
    }
}
