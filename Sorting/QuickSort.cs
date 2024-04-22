namespace QuickSort
{
    internal class QuickSort
    {
        public int Counter => _counter;

        private int _counter;

        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int idx = partition(arr, low, high);

                Sort(arr, low, idx - 1);
                Sort(arr, idx + 1, high);
            }
        }
        private int partition(int[] arr, int low, int high)
        {
            ++ _counter;
            int pivot = arr[low];
            int st = low;
            int end = high;
            int k = high;
            for (int i = high; i > low; i--)
            {
                if (arr[i] > pivot)
                    swap(arr, i, k--);
            }
            swap(arr, low, k);
            return k;
        }

        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
