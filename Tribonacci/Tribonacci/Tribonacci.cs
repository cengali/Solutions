//N-th Tribonacci Number
//The Tribonacci sequence Tn is defined as follows: 

//T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.

//Given n, return the value of Tn.
namespace TribonacciProblem
{
    public static class Solution
    {
        public static int Tribonacci(int n)
        {
            if (n < 2)
                return n;
            if (n == 3)
                return 2;
            return Tribonacci(n - 3, 0, 1, 1);
        }

        private static int Tribonacci(int n, int t0, int t1, int t2)
        {
            if (n > 0)
            {
                return Tribonacci(n - 1, t1, t2, t0 + t1 + t2);
            }
            return t0 + t1 + t2;
        }
    }
}
