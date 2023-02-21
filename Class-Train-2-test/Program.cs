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
            string[] allNum = Console.ReadLine().Split(',');
            Console.WriteLine($"奇數:{string.Join(",", allNum.Where(x => int.Parse(x) % 2 != 0))}");
            Console.WriteLine($"偶數:{string.Join(",", allNum.Where(x => int.Parse(x) % 2 == 0))}");
            Console.ReadLine();
        }
    }
}
