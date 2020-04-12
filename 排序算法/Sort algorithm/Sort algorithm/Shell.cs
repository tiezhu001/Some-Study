using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_algorithm
{
   public class Shell
    {
        /// <summary>
        /// 希尔排序和插入排序就点相似.插入排序是把第一个元素当做有序,后续的元素依次和之前元素进行比较
        /// 希尔排序也是和之前元素进行比较,不同的是希尔排序和之前的元素相比有一个增量,比如增量为4,就是下标相差
        /// 4的元素进行比较,当增量变为1也就是遍历的元素和自己进行比较时,就结束。
        /// </summary>
        /// <param name="array"></param>
        public static void ShellSort(int[] array)
        {
            int len = array.Length;
            for (int gap = len/2; gap > 0; gap=gap/2)
            {
                 
                for (int i = gap; i < len; i++)
                {
                    int j = i;
                    while (j - gap > 0 && array[j] < array[j - gap])
                    {
                        int temp = array[j];
                        array[j] = array[j-gap];
                        array[j - gap] = temp;
                        j -= gap;
                    }
                }

            }

        }



    }
}
