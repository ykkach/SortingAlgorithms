using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Algorithms
{
    public class ShellSort
    {
        public void shell_sort(int[] arr, CancellationToken token)
        {
            var d = arr.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (arr[j - d] > arr[j]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j-d];
                        arr[j-d] = temp;

                        j = j - d;

                        if (token.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                d = d / 2;
            }
        }
    }
}
