using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumbersCountThanCurrent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 8, 1, 2, 3, 3, 5 };
            int[] resultArray = Solution.SmallerNumbersThanCurrent(testArray);

            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine($"{testArray[i]} , {resultArray[i]}");
            }
            Console.ReadKey();
        }
    }
}
