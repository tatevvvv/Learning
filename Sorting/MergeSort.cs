namespace Sorting
{
    // divide and conquer approach
    internal class MergeSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            if (n < 2) { return; }

            var S1 = new int[n / 2];
            var S2 = new int[n / 2];

            for (int i = 0; i < n/2; i++)
            {
                S1[i] = arr[i];
            }

            for (int i = n/2; i < n; i++)
            {
                S2[i] = arr[i];
            }

            Sort(S1);
            Sort(S2);
            // Merge();
        }

        private void Merge(int[] arr1, int[] arr2, int[] final)
        {
            int i = 0;
            int j = 0;

            while(i + j < final.Length) 
            {
                if(j != arr2.Length && i < arr1.Length && arr1[i] < arr2[j])
                {

                }
            }
        }
    }
}
