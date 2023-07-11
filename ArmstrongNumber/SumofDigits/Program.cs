using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsStrongNUmber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            int temp = num;

            while (num > 0)
            {
                int digit = num % 10;

                sum = sum + (digit * digit * digit);
                num = num / 10;               
            }

            if (temp == sum)
            {
                Console.WriteLine("It's a Armstrong Number");
                
            }
            else
            {
                Console.WriteLine("It's NOT a Armstrong Number");
            }
            //Console.WriteLine(sum);
        }
    }
}
