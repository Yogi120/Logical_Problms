using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            string Num = Convert.ToString(Console.ReadLine());

            for(int i =0; i<Num.Length; i++)
            {
                if (Num[i] == Num[Num.Length - 1])
                {
                    Console.WriteLine("It's a Palindrome Number!");
                    break;
                }

                else
                {
                    Console.WriteLine("It's NOT a Palindrome Number!");
                    break;
                }
            }
        }
    }
}
