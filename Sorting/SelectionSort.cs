namespace Sorting
{
    // worst case time is quadratic
    // best case time is quadratic
    internal static class SelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var mindex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[mindex] > arr[j])
                    {
                        mindex = j;
                    }
                }

                var temp = arr[i];
                arr[i] = arr[mindex];
                arr[mindex] = temp;
            }

            return arr;
        }
    }
}
