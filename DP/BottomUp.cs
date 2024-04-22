﻿namespace DP
{
    public class BottomUp
    {
        public int Fib(int n)
        {
            int[] array = new int[n];

            if (n == 1) { return n; }
            if (n == 0) { return n; }

            array[0] = 0;
            array[1] = 1;

            for (int i = 2; i < n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n];
        }
    }
}