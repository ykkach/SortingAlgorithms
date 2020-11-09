using System;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

namespace Algorithms
{
    public class BubbleSort
    {
        public BubbleSort()
        { }
        public void bubble_sort(int[] array, CancellationToken token)
        {

            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                bool checkIfSorted = false;
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        checkIfSorted = true;
                    }
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }
                }
                if (checkIfSorted == false) break;
            }
        }
    }
}
