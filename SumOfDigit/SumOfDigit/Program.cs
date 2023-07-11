using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num > 0)
            {
                int remain = num % 10;
                sum += remain;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
