using System;
using System.Collections.Generic;
using System.Text;

namespace Bubble_Sort
{
    class BynarTree : BubbleSort
    {
        public int BynarSerch(int[] array,int item)
        {
            int low = 0;
            int higth = array.Length - 1;
            while(low <= higth)
            {
                int mid = higth + low;
                int guess = array[mid];
                if(guess == item)
                {
                    return mid;
                }
                if(guess > item)
                {
                    higth = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return 0;
        }
    }
}
