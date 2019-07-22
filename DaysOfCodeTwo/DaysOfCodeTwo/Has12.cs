using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfCodeTwo
{
    public partial class Exercises
    {
        //Create a boolean method called Has12 that takes in an integer array "nums". Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.

        //For example:

        //has12([1, 3, 2]) → true

        //has12([3, 1, 2]) → true

        //has12([3, 1, 4, 5, 2]) → true

        public bool Has12(int[] nums)
        {
            bool result = false;

            bool one = false;
            bool two = false;

            foreach (int i in nums)
            {
                if (i == 1)
                {
                    one = true;
                }
                if (i == 2 && one)
                {
                    two = true;
                }

                if (one && two)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}


