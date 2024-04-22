using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADHW10
{
    internal class Observer12 : Observer
    {
        private int counter = 0;
        private Subject _subject; 
        private int _attribute1;
        private int _attribute2;

        public Observer12(Subject subject)
        {
           _subject = subject;
            _attribute2 = subject.getAttribute2();
            _attribute1 = subject.getAttribute1();
            _subject.Attach(this);
        }

        public int getCounter()
        {
            return counter;
        }

        public int getAttribute1()
        {
            return _attribute1;
        }
        public int getAttribute2()
        {
            return _attribute2;
        }

        public void Update(string description)
        {
            if (description == "attribute1" || description == "attribute2")
            {
                counter++;

                if (counter % 3 == 0)
                {
                    _attribute1 = _subject.getAttribute1();
                    _attribute2 = _subject.getAttribute2();
                }
            }
        }
    }
}
