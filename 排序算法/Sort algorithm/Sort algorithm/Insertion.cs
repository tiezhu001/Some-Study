using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_algorithm
{
    public class Insertion
    {
        public static void InsertionSort(int[] array)
        {
            int len = array.Length;

            if (len > 1)
            {
                for (int i = 1; i < len; i++)
                {
                    int preIndex = i - 1;
                    int currentItem = array[i];
                    while (preIndex >= 0 && currentItem < array[preIndex])
                    {
                        array[preIndex+1] = array[preIndex];
                        preIndex--;
                        
                    }
                    array[preIndex + 1] =currentItem;
                }
               
            }

        }
    }
}
