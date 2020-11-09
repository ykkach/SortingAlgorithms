using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithms
{
    public class QuickSort
    {
        public void Quick_Sort(int[] arr, int left, int right, CancellationToken token)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1, token);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right, token);
                }
                if (token.IsCancellationRequested)
                {
                    return;
                }
            }

        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
