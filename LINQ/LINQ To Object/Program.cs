using System;
using System.IO;
using System.Linq;

namespace LINQ_To_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.找出在字符串列表1中不在字符串列表2中
            string[] string1 = File.ReadAllLines(@"C:\Users\Sunzh\Desktop\a.txt");
            string [] string2 = File.ReadAllLines(@"C:\Users\Sunzh\Desktop\b.txt");
        
            var differentQuery = string1.Except(string2);

            foreach(var item in differentQuery){
                Console.WriteLine(item);
            }


            #endregion

        }
    }
}
