using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 51, 32, 61, 87, 64, 3, 54, 1, 72, 87, 54, 234, 8, 22, 11, 55 };

            int item = 1;

            BubbleSort bubbleSort = new BubbleSort();

            bubbleSort.Bubble(array);

            BynarTree bynarTree = new BynarTree();

            Console.WriteLine(bynarTree.BynarSerch(array, item));


         /* Проверка соритировки массива   
          * 
          * for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
         */
        }

       

    }
}
