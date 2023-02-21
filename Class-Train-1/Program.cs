using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Train_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入以逗號分隔的整數");
            string[] num = Console.ReadLine().Split(',');
            string[] arr = num.Reverse().ToArray();
            foreach (var item in arr)
            {
                Console.Write($"{item},");
            }
            Console.ReadLine();
        }
    }
}
