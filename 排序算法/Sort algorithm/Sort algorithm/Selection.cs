using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_algorithm
{
   public class Selection
    {
        /// <summary>
        /// 找出最小的元素的下标,然后放在数组的开头,然后继续在剩下的元素中找到最小的放到已排序的数组的后边
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SelectionSort(int [] array)
        {
           
            int temp;
            int len = array.Length;
            if (len <= 0) return null;

            for (int i = 0; i < len-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < len; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }

            return array;
        }

        /// 不管数组的长度多长,或者默认顺序是什么时间复杂度都是一样的,所以选择排序适合数组长度小的
        /// 时间复杂度：O(n`2)
        /// 空间复杂度:O(1)
    }
}
