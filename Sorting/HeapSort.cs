using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal static class HeapSort
    {
        public static void Sort(int[] arr)
        {
            heapify(arr);

            var len = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                // swap(arr[0], arr[len - 1]);
                len--;
                int j = 0;
                while (2 * j + 1 < len)
                {
                    int l = 2 * j + 1, r = 2 * j + 2;
                    if (r < len && arr[r] > arr[j] && arr[r] > arr[l])
                    {
                        // swap(arr[r], arr[j]);
                        j = r;
                    }
                    else if (arr[l] > arr[j])
                    {
                        // swap(arr[l], arr[j]);
                        j = l;
                    }
                    else break;
                }
            }
        }

        private static void heapify(int[] arr)
        {
            int j = arr.Length - 1;
            while (j > 0 )
            {
                downHeap(j, arr);
                --j;
            }
        }

        // todo: check for boundaries
        private static void downHeap(int j, int[] arr)
        {
            int l = j * 2 + 1;
            int r = j * 2 + 2;

            if (arr[j] < arr[r] && arr[r] < arr[l])
            {
                var temp = arr[j]; 
                arr[j] = arr[r];
                arr[r] = temp;
            }
            else if (arr[j] < arr[l])
            {
                var temp = arr[j];
                arr[j] = arr[r];
                arr[r] = temp;
            }
        }

        private static void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
