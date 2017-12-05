using System;
using System.Collections.Generic;

namespace MergeSort
{
    public static class InputGenerator
    {
        private const int MaxLength = 25;
        private const int MinLength = 15;
        private const int MaxValue = 100;

        /// <summary>
        /// Generate a random array of integers of random length.  
        /// </summary>
        /// <remarks>The length of the array will be between 15 and 25. 
        /// Values will be betwen 0 and 100.
        /// </remarks>
        /// <returns></returns>
        public static int[] Generate()
        {
            var random = new Random();
            var length = random.Next(MinLength, MaxLength);
            var input = new List<int>();

            for (var i = 0; i < length; i++)
                input.Add(random.Next(MaxValue));

            return input.ToArray();
        }
    }
}