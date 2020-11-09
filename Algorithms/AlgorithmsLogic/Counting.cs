using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithms
{
    public class CountingSort
    {
        public void counting_Sort(int[] array, CancellationToken token)
        {
            int[] sortedArray = new int[array.Length];

            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            int index = (maxVal - minVal) + 1;
            int[] counts = new int[index];

            for (int i = 0; i < array.Length; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                int indexF = (array[i] - minVal);
                counts[indexF]++;
            }

            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                int indexR = (array[i] - minVal);
                sortedArray[counts[indexR]--] = array[i];
            }

            int counter = 0;
            foreach (int aa in sortedArray)
            {
                if (token.IsCancellationRequested)
                {
                    return;
                }
                array[counter] = aa;
                counter++;
            }
        }
    }
}
