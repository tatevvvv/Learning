using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class NestedInteger : INestedInteger
    {
        private readonly int? _integer;
        private readonly List<INestedInteger>? _list;

        public NestedInteger(int? integer, List<INestedInteger>? list)
        {
            _integer = integer;
            _list = list;
        }

        public int? GetInteger()
        {
            return _integer;
        }

        public List<INestedInteger>? GetList()
        {
            return _list;
        }

        public bool IsInteger()
        {
            return _integer != null;
        }
    }
}
