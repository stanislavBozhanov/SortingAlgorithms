using System;
using System.Linq;

class InsertionSort
{
    static void Main()
    {
        int[] array = { 1, 7, 3, 22, 32, 35, 1, 3, 1, 46, 78, 3, 3, 45, };

        for (int i = 1; i < array.Length; i++)
        {
            for (int k = i; k > 0 && array[k] < array[k - 1]; k--)
            {
                int temp = array[k - 1];
                array[k - 1] = array[k];
                array[k] = temp;
            }
        }
    }
}