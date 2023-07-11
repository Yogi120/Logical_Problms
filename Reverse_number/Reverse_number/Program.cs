using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string ReverseNum = "";

            while (num > 0)
            {
                int digit = num % 10;
                //Console.WriteLine(digit);
                ReverseNum = ReverseNum + digit;
                num = num / 10;
            }
            Console.WriteLine(ReverseNum);
        }
    }
}
