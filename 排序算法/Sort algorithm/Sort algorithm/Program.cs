using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            int[] array = new int[] { 8, 9, 7, 1, 5, 797, 7, 58, 1 };

            Console.WriteLine("冒泡排序");
            // 1.冒泡排序
            int[] newArray1 = Bubble.BubbleSort(array);
            foreach (var item in newArray1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("插入排序");
            // 2.插入排序
            Insertion.InsertionSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("---------------------------------");

            // 3.选择排序
            Console.WriteLine("选择排序");
            int[] newArray2 = Selection.SelectionSort(array);
            foreach (var item in newArray2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");


            // 4.希尔排序
            Console.WriteLine("希尔排序");
            int[] array2 = new int[] { 8, 9, 7, 1, 5, 797, 7, 58, 1 };
            Shell.ShellSort(array2);
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            Console.ReadKey();
        }
    }
}
