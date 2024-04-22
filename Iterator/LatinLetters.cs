using System.Collections;

namespace Iterator
{
    public class LatinLetters : IEnumerable<char>
    {
        public LatinLetters()
        {
        }

        public IEnumerator<char> GetEnumerator()
        {
            return new LanguageIterator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LanguageIterator();
        }
    }
}
