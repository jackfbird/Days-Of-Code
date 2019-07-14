using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeDay0
{
    public partial class Exercises
    {
        public int[] SwapEnds(int[] nums)
        {
            if(nums.Length == 0)
            {
                return nums;
            }

            int last = nums[nums.Length - 1];
            nums[nums.Length - 1] = nums[0];
            nums[0] = last;

            return nums;
        }

    }
}
