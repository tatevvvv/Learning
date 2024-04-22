namespace OOADHW10
{
    internal class Observer1 : Observer
    {
        private int _attribute1;
        private Subject _subject;

        public Observer1(Subject subject)
        {
            _subject = subject;
            _attribute1 = subject.getAttribute1();
            _subject.Attach(this);
        }

        public int getAttribute1()
        {
            return _attribute1;
        }

        public void Update(string description)
        {
            if (description == "attribute1")
            {
                _attribute1 = _subject.getAttribute1();
            }
        }
    }
}
