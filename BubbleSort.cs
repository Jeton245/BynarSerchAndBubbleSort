using System;
using System.Collections.Generic;
using System.Text;

namespace Bubble_Sort
{
    class BubbleSort : Program
    {
        
        public int[] Bubble(int[] arrayBubble)
        {
            for (int i = 0; i < arrayBubble.Length - 1; i++)
            {
                for (int j = 0; j < arrayBubble.Length - i - 1; j++)
                {
                    if (arrayBubble[j] > arrayBubble[j + 1])
                    {
                        Swop(ref arrayBubble[j], ref arrayBubble[j + 1]);
                    }
                }
            }
            return arrayBubble;
        }

        public void Swop(ref int positionA,ref int positionB)
        {
            int numThree = positionA;
            positionA = positionB;
            positionB = numThree;
        }

    }
}
