using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeSort
{
    public static class MergeSort
    {
        /// <summary>
        /// Sort an array of integers using merge sort
        /// </summary>
        /// <param name="source">Unsorted array of integers</param>
        /// <returns>Task for the sorted array of integers</returns>
        public static async Task<int[]> SortAsync(int[] source)
        {
            var length = source.Length;

            if (length <= 1)
                return source;


            var midPoint = length / 2;

            var left = new int[midPoint];
            Array.Copy(source, 0, left, 0, midPoint);

            var right = new int[length - midPoint];
            Array.Copy(source, midPoint, right, 0, length - midPoint);

            var result = await Task.WhenAll(Task.Run(() => SortAsync(left)), Task.Run(() => SortAsync(right)));

            return Merge(result[0], result[1]);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var result = new List<int>();

            var leftList = new List<int>(left);
            var rightList = new List<int>(right);
            var leftIndex = 0;
            var rightIndex = 0;

            while (leftList.Any() && rightList.Any())
            {
                var leftElement = leftList[leftIndex];
                var rigtElement = rightList[rightIndex];
                if (leftElement < rigtElement)
                {
                    result.Add(leftElement);
                    leftList.RemoveAt(0);
                }
                else
                {
                    result.Add(rigtElement);
                    rightList.RemoveAt(0);
                }
            }


            result.AddRange(leftList.Any() ? leftList : rightList);


            return result.ToArray();
        }
    }
}