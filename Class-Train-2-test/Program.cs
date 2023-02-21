using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Train_2_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入以逗號分隔的整數");
            List<int> list = new List<int>();
            
            string[] allNum = Console.ReadLine().Split(',');
            foreach (string str in allNum)
            {
                list.Add(int.Parse(str));
            }
            var odd = list.Where(x=> x%2 ==0);
            var even = list.Where(x => x % 2 != 0);
            Console.WriteLine("奇數:");
            foreach (var item in odd)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("\n偶數:");
            foreach (var item in even)
            {
                Console.Write(item + ",");
            }
            Console.Read();
        }
    }
}
