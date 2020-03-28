using System;

namespace TribonacciProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Solution.Tribonacci(number));
            Console.ReadKey();
        }

    }
}
