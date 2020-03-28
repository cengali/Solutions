using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerNumbersCountThanCurrent
{
    class Solution
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        if (nums[i] > nums[j])
                        {
                            result[i] = result[i]++;
                        }
                        else
                        {
                            result[j]++;
                        }
                    }
                }
            }
            return result;
        }
    }
}
