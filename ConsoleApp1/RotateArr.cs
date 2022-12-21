using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RotateArr
    {
        //public void Rotate(int[] nums, int t)
        //{
        //    int postInt = 1;
        //    for (int i = 0; i <= t - 1; i++)
        //    {
        //        int tempkey = nums[0];
        //        nums[0] = nums[nums.Length - 1];
        //        for (int k = nums.Length - 1; k >= postInt; k--)
        //        {
        //            nums[k] = nums[k - 1];
        //        }
        //        nums[i == 0 ? i + 1 : i] = tempkey;
        //        postInt++;
        //    }
        //}
        public void Rotate(int[] nums, int k)
        {
            Dictionary<char, int> dict1 =
                       new Dictionary<char, int>();
            int r = 0;
            int[] temp = nums;
            for (int j = (nums.Length-k); j < nums.Length; j++)
            {
                nums[j] = nums[r];
                r++;
            }
            //for (int i = 1; i <= k; i++)
            //{
            //    int temp = nums[0];
            //    nums[0] = nums[nums.Length - 1];
            //    int r = 0;
            //    for (int j = k; j < nums.Length; j++)
            //    {
            //        nums[k] = nums[r];
            //            r++;
            //    }
                
            //}
        }
    }
}
