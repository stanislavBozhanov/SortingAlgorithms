using System;
using System.Linq;

class BubbleSort
{
    static void Main()
    {
        int[] array = { 1, 7, 3, 22, 32, 35, 1, 3, 1, 46, 78, 3, 3, 45, };

        for (int i = 0; i < array.Length; i++)
        {
            bool swapped = false;
            for (int j = array.Length - 1; j > 1 + i ; j--)
            {
                if (array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }
}