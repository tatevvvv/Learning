using System.Collections;

namespace Iterator
{
    internal class EvenIndexIterator : IEnumerator<int>
    {
        private int[] _array;
        private int _cursor;
        private int _current;


        public EvenIndexIterator(int[] array)
        {
            _array = array;
            _cursor = -2;
        }

        public int Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _cursor = _cursor + 2;
            if (_cursor < _array.Length)
            {
                _current = _array[_cursor];
            }

            return _cursor < _array.Length;
        }

        public void Reset()
        {
            _cursor = -1;
        }
    }
}
