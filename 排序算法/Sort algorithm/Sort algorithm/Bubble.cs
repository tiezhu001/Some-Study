using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_algorithm
{

   public class Bubble
    {
        /// <summary>
        /// 冒泡排序的想法就是:两两比较,如果第i个大于第i+1个元素，那么就交换两个元素的位置
        /// 因为很少中情况是第一个元素刚好比后边的元素都大，而且后边的元素也不是按照顺序排序的
        /// 所以第1个元素和后边的元素比较后，第i+1个元素也要继续和后边的元素排序,所以第一层循环是
        /// 拿出来数组中每一个元素,第二个循环是数组中的每一个元素和后边的元素进行比较
        /// </summary>
        /// <param name="array">要比较的数组</param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] array)
        {
            int len = array.Length;
            if (len <= 0) return null;

            for (int i = 0; i < len-1; i++)
            {
                for (int j = 0; j < len-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;

        }

        ///时间复杂度:最好O(n)，最坏O(n`2)
        ///空间复杂度:O(1)
    }
}
