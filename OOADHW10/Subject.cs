using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADHW10
{
    internal class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int _attribute1;
        private int _attribute2;

        public Subject(int attr1, int attr2)
        {
            _attribute1 = attr1;
            _attribute2 = attr2;
        }

        public int getAttribute1()
        { 
            return _attribute1; 
        }
        public int getAttribute2()
        {
            return _attribute2; 
        }

        public void setAttribute1(int attr1)
        {
            _attribute1 = attr1;
            Notify("attribute1");
        }

        public void setAttribute2(int attr2)
        {
            _attribute2 = attr2;
            Notify("attribute2");
        }

        public void Attach(Observer concreteObject)
        {
            observers.Add(concreteObject);
        }

        public void Notify(string description)
        {
            foreach (Observer o in observers)
            {
                o.Update(description);
            }
        }
    }
}
