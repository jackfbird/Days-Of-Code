using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCodeDaySeven
{
    public partial class Exercises
    {
        public bool NoTriples(int[] nums)
        {
            bool result = true;

            for (int i = 0; i < (nums.Length - 2); i++)
            {
                if (nums[i + 1] == nums[i] && nums[i + 2] == nums[i])
                {
                    result = false;
                }
            }
            return result;
        }
    }
}






