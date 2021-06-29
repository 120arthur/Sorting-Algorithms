using System;
using System.Collections.Generic;

namespace Sorting_Algorithms
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            // Selecton Sort
            var selection = new SelectionSort();
            var list = new List<int>(){10,9,8,7,6,5,5,7,3,6,5,56,1,23,34,54,23,54,3,9,4,3,2,1};
            Console.WriteLine($"List: ({string.Join(", ", list)}).");
            list =  selection.NumberOrdering(list);
            Console.WriteLine($"Selection Sort list: ({string.Join(", ", list)}).");
        }
        
        
    }
}