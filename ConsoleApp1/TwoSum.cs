using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoSum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> My_dict2 =
                  new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int tempval = target - nums[i];  /// 11-1 10
                if (My_dict2.ContainsKey(tempval))
                {
                    return new int[] { My_dict2[tempval], i };
                }
                if (!My_dict2.ContainsKey(nums[i]))
                {
                    My_dict2.Add(nums[i], i);
                }
            }
            return new int[] { };
        }
    }
}
