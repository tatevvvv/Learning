namespace OOADHW11.SortingAlgorithms
{
    public class PartialSort : Subject
    {
        private Subject _insertionSort;
        private int _h;

        public PartialSort(int h, Subject insertionSort)
        {
            _h = h;
            _insertionSort = insertionSort;
        }

        public void Sort(Client client)
        {
            int[] array = client.Sequence;

            for (int i = _h; i < array.Length; i++)
            {
                var currentKey = array[i];
                var k = i;
                while (k >= _h && array[k - _h] > currentKey)
                {
                    array[k] = array[k - _h];
                    k -= _h;
                }
                array[k] = currentKey;
            }

            _insertionSort.Sort(client);
        }
    }
}
