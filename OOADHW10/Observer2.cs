namespace OOADHW10
{
    internal class Observer2 : Observer
    {
        private int _attribute2;
        private Subject _subject;

        public Observer2(Subject subject)
        {
            _subject = subject;
            _attribute2 = subject.getAttribute2();
            _subject.Attach(this);
        }

        public int getAttribute2()
        {
            return _attribute2;
        }

        public void Update(string description)
        {
            if (description == "attribute2")
            {
                _attribute2 = _subject.getAttribute2();
            }
        }
    }
}
