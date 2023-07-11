using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine("It's Not a Prime Number");
                    break;
                }

                else
                {
                    Console.WriteLine("It's a prime number");
                    break;
                }
            }
        }
    }
}
