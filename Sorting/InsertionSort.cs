namespace Sorting
{
    // we pick ith element , compare all before ith and find perfect index for it and insert it into that index
    // worst case quadratic
    // array is sorted, O(n)
    internal static class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var curr = arr[i];
                int j = i;
                while (j > 0 && curr < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = curr;
            }

            return arr;
        }
    }
}
