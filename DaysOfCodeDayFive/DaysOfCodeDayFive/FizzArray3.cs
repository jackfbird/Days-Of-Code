﻿using System;
using System.Collections.Generic;

namespace DaysOfCodeDayFive
{
    public partial class Exercises
    {

        //  Create an integer array method called FizzArray3 that takes in two integers "start" and "end"

        //Given start and end numbers, return a new array containing the sequence of integers from start up to but not including end, so start=5 and end = 10 yields {5, 6, 7, 8, 9}. The end number will be greater or equal to the start number.Note that a length-0 array is valid.

        //fizzArray3(5, 10) → [5, 6, 7, 8, 9]

        //    fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]

        //    fizzArray3(1, 3) → [1, 2]

        public int[] FizzArray3(int start, int end)
        {
            if (end - start == 0)
            {
                int[] zeroArray = new int[0];
                return zeroArray;
            }

            int count = (end - start);
            int[] newArray = new int[end - start];

            for (int i = 0; i < count; i++)
            {
                if(end > start)
                {
                    newArray[i] = start;
                    start++;
                }
            }

            return newArray;
        }
    }
}