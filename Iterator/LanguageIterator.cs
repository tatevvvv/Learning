using System.Collections;

namespace Iterator
{
    internal class LanguageIterator : IEnumerator<char>
    {
        private char _currentLetter = (char)('A' - 1);

        public LanguageIterator()
        {
        }

        public char Current => _currentLetter;

        object IEnumerator.Current => _currentLetter;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _currentLetter++;
            return _currentLetter < 'z';
        }

        public void Reset()
        {
            _currentLetter = (char)('A' - 1);
        }
    }
}
