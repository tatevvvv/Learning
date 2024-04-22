﻿namespace OOADHW11.SortingAlgorithms
{
    internal class InsertionSort : Subject
    {
        public void Sort(Client client)
        {
            int[] array = client.Sequence;

            for (int i = 1; i < array.Length; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }
    }
}
