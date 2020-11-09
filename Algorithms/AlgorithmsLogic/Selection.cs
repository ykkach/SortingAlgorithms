using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

namespace Algorithms
{
    public class SelectionSort
    {
        public SelectionSort()
        { }

        public void selection_sort(int[] array, CancellationToken token)
        {
            int min_ind, arrayLen = array.Length;

            for (int i = 0; i < arrayLen - 1; i++)
            {
                min_ind = i;
                for (int j = i + 1; j < arrayLen; j++)
                {
                    if (array[j] < array[min_ind])
                    {
                        min_ind = j;
                    }
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                }
                int temp = array[i];
                array[i] = array[min_ind];
                array[min_ind] = temp;

            }
        }
    }
}
