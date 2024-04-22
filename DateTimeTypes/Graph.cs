using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTypes
{
    internal class Graph
    {
        private LinkedList<int>[] adjacentList;

        public int Count;
        public LinkedList<int>[] AdjacentList => adjacentList;

        public Graph(int capacity, LinkedList<int>[] adj)
        {
            this.Count = capacity;
            adjacentList = adj;
        }
    }
}
