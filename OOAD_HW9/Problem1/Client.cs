using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HW9.Problem1
{
    internal class Client
    {
        private List<int> sequenceOfNumbers = new List<int>();

        private SortingStrategy sortingStrategy;

        public Client(SortingStrategy sortingStrategy, List<int> numbers)
        {
            this.sortingStrategy = sortingStrategy;
            sequenceOfNumbers = numbers;
        }

        public List<int> GetNumbers => sequenceOfNumbers;

        public void Sort()
        {
            sortingStrategy.Sort(this);
        }

        public void Print()
        {
            Console.WriteLine("Printing something");
        }
    }
}
