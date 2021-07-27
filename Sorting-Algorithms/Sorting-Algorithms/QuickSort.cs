
namespace Sorting_Algorithms
{
    public class QuickSort
    {
        public int[] NumberOrdering(int[] vetor)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;

            NumberQuickSort(vetor, inicio, fim);

            return vetor;
        }

        private void NumberQuickSort(int[] unsortedList, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int pivot = unsortedList[inicio];
                int begin = inicio + 1;
                int end = fim;

                while (begin <= end)
                {
                    if (unsortedList[begin] <= pivot)
                    {
                        begin++;
                    }
                    else if (pivot < unsortedList[end])
                    {
                        end--;
                    }
                    else
                    {
                        int troca = unsortedList[begin];
                        unsortedList[begin] = unsortedList[end];
                        unsortedList[end] = troca;
                        begin++;
                        end--;
                    }
                }

                unsortedList[inicio] = unsortedList[end];
                unsortedList[end] = pivot;

                NumberQuickSort(unsortedList, inicio, end - 1);
                NumberQuickSort(unsortedList, end + 1, fim);
            }
        }

    }
}