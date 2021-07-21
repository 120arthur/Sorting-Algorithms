using System.Collections.Generic;

namespace Sorting_Algorithms
{
    public class BubbleSort
    {
        public List<int> NumberOrdering(List<int> list)
        {
            var size = list.Count;
            for (var i = size - 1; i >= 1; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    if (list[j] <= list[j + 1]) continue;
                    var aux = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = aux;
                }
            }

            return list;
        }
    }
}