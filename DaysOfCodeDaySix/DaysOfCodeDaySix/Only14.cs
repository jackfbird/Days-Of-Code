using System;

namespace DaysOfCodeDaySix
{
    public partial class Exercises
    {
        // Create a boolean method called Only14 that takes in an integer array “nums”. Given an array of ints, return true if every element is a 1 or a 4.

        //only14([1, 4, 1, 4]) → true

        //only14([1, 4, 2, 4]) → false

        //only14([1, 1]) → true

        public bool Only14(int[] nums)
        {
            bool result = false;
            int count = 0;

            foreach (int number in nums)
            {
                if (number == 1 || number == 4)
                {
                    count++;
                }

            }
            if (count == nums.Length)
            {
                result = true;
            }

            return result;
        }
    }
}









