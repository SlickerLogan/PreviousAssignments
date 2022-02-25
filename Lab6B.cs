using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Lab6B
    {
        public static void Main(String[] args)
        {
            int i = 1;
            Random rnd = new Random();
            Console.WriteLine("Enter a number between 1 and 1000:");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input >= 1 && input <= 1000)
            {
                
                
               
                int guess = rnd.Next(1, 1000);
                i++;
                if (guess == input)
                {
                    Console.WriteLine("My guess was " + guess);
                    Console.WriteLine("I guessed the number was " + guess + " and it only took me " + i + " guesses");
                    break;
                }
                else
                {

                    Console.WriteLine("My guess was " + guess);
                   
                }
            }
        }
    }
}
