using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Assignment4B
    {
        public static void Main(String[] args)

        {

            int p = 1;

            do

            {

                Console.WriteLine("Enter the checkerboard's width:");

                int width = Convert.ToInt32(Console.ReadLine());

                if (width >= 0)

                {

                    Console.WriteLine("Enter the checkerboard's height:");

                    int height = Convert.ToInt32(Console.ReadLine());

                    if (height >= 0)

                    {

                        p = 0;

                        int k = 1;

                        while (k <= height)

                        {

                            if (k % 2 == 0)

                            {

                                Console.WriteLine("");

                                k++;

                                for (int i = 1; i <= width; i++)

                                {

                                    if (i % 2 == 0)

                                    {

                                        Console.Write("■");

                                    }

                                    else

                                    {

                                        Console.Write("□");

                                    }

                                }

                            }

                            else

                            {

                                k++;

                                if (k % 2 == 0)

                                {

                                    Console.WriteLine("");

                                    for (int i = 1; i <= width; i++)

                                    {

                                        if (i % 2 == 0)

                                        {

                                            Console.Write("□");

                                        }

                                        else

                                        {

                                            Console.Write("■");

                                        }

                                    }

                                }



                            }

                        }



                    }

                    else

                    {

                        Console.WriteLine("Please enter a valid height!");

                    }

                }





                else

                {

                    Console.WriteLine("Please enter a valid width!");

                }



            } while (p == 1);

        }


    }
}
