using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("New num1: " + a);
            Console.WriteLine("New num2: " + b);   
        }
    }
}
