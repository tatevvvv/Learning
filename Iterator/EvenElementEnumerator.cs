using System.Collections;

namespace Iterator
{
    internal class EvenElementEnumerator : IEnumerator<int>
    {
        private readonly int[] _array;
        private int _index;
        private int _current;

        public EvenElementEnumerator(int[] array)
        {
            _index = 0;
            _array = array;
        }

        public int Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            while (_index < _array.Length && _array[_index] % 2 != 0)
            {
                _index++;
            }

            if (_index < _array.Length)
            {
                _current = _array[_index++];
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
