using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Sorting_Algorithms
{
    public class SelectionSort
    {
        public List<int> NumberOrdering(List<int> list)
        {
            int min, aux;
            for (int i = 0; i < list.Count; i++)
            {
                min = i;
                for (var j = i + 1; j < list.Count; j++)
                    if (list[j] < list[min])
                        min = j;
                
                if (min == i) continue;
            }

            return list;
        }
    }
}