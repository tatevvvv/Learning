namespace DP
{
    // using memorization
    internal class TopDown
    {
        public int Fib(int n)
        {
            // have an array and store a[ith] value in array
            if (n <= 1) return n;

            // if(a[i] is not null) read a[i] value
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
