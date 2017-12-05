using System;

namespace MergeSort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = InputGenerator.Generate();
            Console.WriteLine($"Unsorted: {string.Join(", ", input)}");
            var result =  MergeSort.SortAsync(input).Result;
            Console.WriteLine($"Sorted: {string.Join(", ", result)}");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }
    }
}