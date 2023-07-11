using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int factorial = 1;
            int Num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < Num; i++)
            //{
            //    factorial = factorial * i;

            //}

            int i = 1;

            while (i < Num)
            {
                factorial = factorial * i;
                i++;
            }
            Console.WriteLine(factorial);


           
        }
    }
}
