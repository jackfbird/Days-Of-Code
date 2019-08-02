using System;

namespace DaysOfCodeDayTen
{
    public partial class Exercises
    {
        //        Create a boolean method called More14 that takes in an array of type integer “nums”. Given an array of ints, return true if the number of 1's is greater than the number of 4's

        //more14([1, 4, 1]) → true

        //more14([1, 4, 1, 4]) → false

        //more14([1, 1]) → true

        public bool More14(int[] nums)
        {
            bool result = false;
            int countOne = 0;
            int countFour = 0;


            foreach (int number in nums)
            {
                if (number == 1)
                {
                    countOne++;
                }

                if(number == 4)
                {
                    countFour++;
                }

            }

            if (countOne > countFour)
            {
                result = true;
            }

            return result;
        }
    }
}
