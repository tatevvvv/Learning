using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class EvenIndexEnumerable : IEnumerable<int>
    {
        private int[] _array;

        public EvenIndexEnumerable(int[] array)
        {
            _array = array;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new EvenIndexIterator(_array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EvenIndexIterator(_array);
        }
    }
}
