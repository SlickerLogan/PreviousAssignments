using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Assignment3C
    {
        public static void Main(String[] args)
        {
            string phone;
            double version;
            string nfc;
            string bluetooth;

            Console.WriteLine("[App Checklist]");
            Console.WriteLine("What mobile device do you have?");
            phone = Console.ReadLine();
            phone = phone.ToLower();
            if (phone == "apple" || phone == "android")
            {
                Console.WriteLine("What version do you have?");
                version = Convert.ToDouble(Console.ReadLine());
                if (version >= 10 && phone == "android")
                {
                    Console.WriteLine("Congratulations, you can run the app!");
                }
                else if (version < 10 && phone == "android")
                {
                    Console.WriteLine("Does your device support Bluetooth connections?");
                    bluetooth = Console.ReadLine();
                    bluetooth = bluetooth.ToLower();
                    if (bluetooth == "yes")
                    {
                        Console.WriteLine("Congratulations, you can run the app!");
                    }
                    else
                    {
                        Console.WriteLine("I’m sorry, our app does not support your device.");
                    }
                }
                if (version >= 14 && phone == "apple")
                {
                    Console.WriteLine("Congratulations, you can run the app!");
                }
                else if (version < 14 && phone == "apple")
                {
                    Console.WriteLine("Does your device support NFC?");
                    nfc = Console.ReadLine();
                    if (nfc == "yes")
                    {
                        Console.WriteLine("Congratulations, you can run the app!");
                    }
                    else
                    {
                        Console.WriteLine("I’m sorry, our app does not support your device.");
                    }

                }
            

            }
            else
            {
                Console.WriteLine("I’m sorry, our app does not support your device.");

            }
        }
    }
}
