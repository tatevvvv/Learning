using OOADHW11.SortingAlgorithms;

namespace OOADHW11
{
    public class Client
    {
        private Subject _subject;
        private int[] _sequence;

        public Client(Subject subject, int[] sequence)
        {
            _subject = subject;
            _sequence = sequence;
        }

        public Subject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public int[] Sequence
        {
            get { return _sequence; }
            set { _sequence = value; }
        }

        public void sort()
        {
            _subject.Sort(this);
        }

        public void print()
        {
            if (_sequence != null)
            {
                Console.WriteLine(string.Join(", ", _sequence));
            }
        }
    }
}
