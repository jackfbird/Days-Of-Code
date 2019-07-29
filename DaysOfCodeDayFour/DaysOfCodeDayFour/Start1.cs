using System;

namespace DaysOfCodeDayFour
{
    // Create an integer method called Start1 that takes in two integer arrays "a" and "b". Start with 2 int arrays, a and b, of any length.Return how many of the arrays have 1 as their first element.

    //start1([1, 2, 3], [1, 3]) → 2

    //start1([7, 2, 3], [1]) → 1

    //start1([1, 2], ) → 1


    public partial class Exercises
    {
        public int Start1(int[] a, int[] b)
        {
            int aCount = 0;
            int bCount = 0;
            int result = 0;

            if(a.Length > 0)
            {
                if(a[0] == 1)
                {
                    aCount++;
                }
                result += aCount;
            }

            if (b.Length > 0)
            {
                if (b[0] == 1)
                {
                    bCount++;
                }
                result += bCount;
            }

            return result;
        }

    }
}




