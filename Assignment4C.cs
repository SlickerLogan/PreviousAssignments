using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Assignment4C
    {
        public static void Main(String[] args)

        {

            Console.WriteLine("[Mathletes Game]");

            Console.WriteLine("Chose a game mode  (0=Easy, 1=Hard):");

            int mode = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            int p = 0;

            int i = 1;

            if (mode == 0)

            {

                Console.WriteLine("Playing on easy mode, huh? Okay!");

                do

                {

                    int x = rnd.Next(-255, 255);

                    int y = rnd.Next(-255, 255);

                    int ans = x * y;

                    Console.WriteLine("Q" + i + ". " + x + " * " + y + " = ?");

                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == ans)

                    {

                        Console.WriteLine("Correct!");

                        i++;

                    }

                    else

                    {

                        Console.WriteLine("Incrrect! Try again");

                        p++;



                    }

                } while (p <= 2 & i <= 5);

            }

            else if (mode == 1)

            {

                Console.WriteLine("So, you want a challenge? Okay!");

                do

                {

                    int x = rnd.Next(-255, 255);

                    int y = rnd.Next(-255, 255);

                    int ans = x * y;

                    Console.WriteLine("Q" + i + ". " + x + " * " + y + " = ?");

                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == ans)

                    {

                        Console.WriteLine("Correct!");

                        i++;

                    }

                    else

                    {

                        Console.WriteLine("Incrrect! Try again");

                        p++;



                    }

                } while (p <= 0 & i <= 10);

                if ((i == 5 & p <= 2) || (i == 10 & p == 0))

                {

                    Console.WriteLine("You win!");

                }

                else

                {

                    Console.WriteLine("Game over...");

                }

            }

        }


    }
}
