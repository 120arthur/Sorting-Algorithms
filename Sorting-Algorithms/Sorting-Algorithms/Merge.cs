using System.Collections.Generic;
using System.Linq;

namespace Sorting_Algorithms
{
    class Merge
    {
        public List<int> NumberOrdering(List<int> list)
        {
            if (list.Count <= 1) return list;

            var left = new List<int>();
            var right = new List<int>();

            var middle = list.Count / 2;

            for (var i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }

            for (var i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }
           left = NumberOrdering(left);
           right = NumberOrdering(right);
            return MergeList(left, right);
        }

        private List<int> MergeList(List<int> leftToOrder, List<int> rightToOrder)
        {
            var result = new List<int>();
            while (leftToOrder.Count > 0 || rightToOrder.Count > 0)
            {
                if (rightToOrder.Count > 0 && leftToOrder.Count > 0)
                {
                    if (leftToOrder.First() <= rightToOrder.First())
                    {
                        result.Add(leftToOrder.First());
                        leftToOrder.Remove(leftToOrder.First());
                    }
                    else
                    {
                        result.Add(rightToOrder.First());
                        rightToOrder.Remove(rightToOrder.First());
                    }
                }
                else if (leftToOrder.Count > 0)
                {
                    result.Add(leftToOrder.First());
                    leftToOrder.Remove(leftToOrder.First());
                }
                else
                {
                    result.Add(rightToOrder.First());
                    rightToOrder.Remove(rightToOrder.First());
                }
            }

            return result;
        }
    }
}