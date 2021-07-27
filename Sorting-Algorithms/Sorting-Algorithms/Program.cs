using System;
using System.Collections.Generic;

namespace Sorting_Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Selection Sort
            Console.WriteLine(@"
             Selection Sort");
            
            var selection = new SelectionSort();
            var list = new List<int>() {10, 9, 8, 7, 6, 5, 5, 7, 3, 6, 5, 56, 1, 23, 34, 54, 23, 54, 3, 9, 4, 3, 2, 1};
            Console.WriteLine($"List: ({string.Join(", ", list)}).");
            Console.WriteLine($"Selection Sort list: ({string.Join(", ", selection.NumberOrdering(list))}).");

            //Bubble Sort
            Console.WriteLine(@"
             Bubble Sort
             ");
            
            var bubble = new BubbleSort();
            var list2 = new List<int>() {30, 2, 82, 79, 85, 48, 64, 2, 96, 54, 854, 557, 15, 615, 68, 66, 168, 84, 895, 94, 4, 96};
            Console.WriteLine($"List: ({string.Join(", ", list2)}).");
            list2 = bubble.NumberOrdering(list2);
            Console.WriteLine($"Selection Sort list: ({string.Join(", ", list2)}).");

            // Merge Sort
            Console.WriteLine(@"
                         Merge Sort
                         ");
            var list3 = new List<int>() { 30, 2, 82, 79, 85, 48, 64, 2, 96, 54, 854, 557, 15, 615, 68, 66, 168, 84, 895, 94, 4, 96 };
            var mergeSort = new Merge();
            Console.WriteLine($"List: ({string.Join(", ", list3)}).");
            Console.WriteLine($"Merge Sort list: ({string.Join(", ",  mergeSort.NumberOrdering(list3))}).");


            // Quick Sort
            Console.WriteLine(@"
                         Quick Sort
                         ");
            var quick = new QuickSort();
            var list4 = new[] { 30, 2, 82, 79, 85, 48, 64, 2, 96, 54, 854, 557, 15, 615, 68, 66, 168, 84, 895, 94, 4, 96 };
            Console.WriteLine($"List: ({string.Join(", ", list4)}).");
            list4 = quick.NumberOrdering(list4);
            Console.WriteLine($"Quick Sort list: ({string.Join(", ", list4)}).");

            Console.ReadKey();
        }
    }
}
