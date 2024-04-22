using System.Collections;

namespace Iterator
{
    internal class FibonacciIterator : IEnumerator<int>
    {
        private const int _maxLimit = 233;
        private int _prePrevious;
        private int _previous;
        private int _current;

        public FibonacciIterator()
        {
            _prePrevious = -1;
            _previous = 1;
        }

        public int Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _current = _prePrevious + _previous;
            _prePrevious = _previous;
            _previous = _current;

            return _current < _maxLimit;
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}
