using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Assignment4A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Times Table Generator]");
            int loop = 1;
            do
            {                
                Console.WriteLine("Enter your start number:");
                int start = Convert.ToInt32(Console.ReadLine());
                if (start >= 0)
                {
                    loop = 0;
                    Console.WriteLine("Enter the limit you want to multiply to:");
                    int i = 1;
                    int limit = Convert.ToInt32(Console.ReadLine());
                    while (i <= limit)
                    {
                        int num = start * i;
                        Console.WriteLine(start + " * " + i + " = " + num);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Input must be positive! Try again.");
                }
            } while (loop == 1);
        }
    }
}
