using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace Algorithms
{

    public class MergeSort
    {
        public MergeSort()
        { }
        private static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        public void merge_Sort(int[] input, int left, int right, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                return;
            }

            if (left < right)
            {
                int middle = (left + right) / 2;

                merge_Sort(input, left, middle, token);
                merge_Sort(input, middle + 1, right, token);

                Merge(input, left, middle, right);
            }
        }
    }
}
