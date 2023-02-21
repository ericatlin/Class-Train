using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Train_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入以逗號分隔的整數");
            string[] num = Console.ReadLine().Split(',');
            
            string[] oddNum = new string[num.Length];
            string[] evenNum = new string[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i]) %2 == 0)
                {
                    evenNum[i] = num[i];
                }
                else
                {
                    oddNum[i]= num[i];
                }
            }
            var oddNumOrderby = oddNum.OrderBy(x => x).Where(x => !string.IsNullOrEmpty(x));
            var evenNumOrderby = evenNum.OrderBy(x => x);
            Console.WriteLine("奇數:");
            foreach (var i in oddNumOrderby) { Console.Write(i+","); }
            Console.WriteLine("偶數:");
            foreach (var i in evenNumOrderby) { Console.Write(i + ","); }
            Console.ReadLine();
        }
    }
}
