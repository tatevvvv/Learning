using System.Collections;

namespace Iterator
{
    public class NestedIntegerIterator : IEnumerator<int>
    {
        private int _outerCursor;
        private int _innerCursor;
        private int _current;

        private readonly IList<INestedInteger> _nestedIntegers;

        public NestedIntegerIterator(IList<INestedInteger> nestedIntegers)
        {
            _outerCursor = 0;
            _innerCursor = 0;

            _nestedIntegers = nestedIntegers;
        }

        public int Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_outerCursor < _nestedIntegers.Count)
            {
                var item = _nestedIntegers[_outerCursor];
                if (item.IsInteger())
                {
                    _current = item.GetInteger()!.Value;
                    _outerCursor++;
                    _innerCursor = 0;
                }
                else
                {
                    var list = _nestedIntegers[_outerCursor].GetList();
                    // _current = list[_innerCursor];
                    _innerCursor++;
                    if (_innerCursor >= list.Count)
                    {
                        _outerCursor++;
                        _innerCursor = 0;
                    }
                }

                return true;
            }

            return false;
        }

        public void Reset()
        {
            _innerCursor = 0;
            _current = 0;
            _outerCursor = 0;
        }
    }
}
