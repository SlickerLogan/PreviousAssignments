using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Assignment2B
    {
        public static void Main(String[] args)
        {
            double lengthPent;
            double perimeterPent;
            double areaPent;
            Console.WriteLine("[Pentagon Calculator]");
            Console.WriteLine("Enter the length of  one side:");
            lengthPent = Convert.ToDouble(Console.ReadLine());
            perimeterPent = 5 * lengthPent;
            Console.WriteLine("Pentagon Perimeter = " + perimeterPent);
            areaPent = .25 * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) * (lengthPent * lengthPent);
            Console.WriteLine(String.Format("Pentagon Area = {0:0.00}", areaPent));

            double lengthHex;
            double perimeterHex;
            double areaHex;
            Console.WriteLine("[Hexagon Calculator]");
            Console.WriteLine("Enter the length of one side:");
            lengthHex = Convert.ToDouble(Console.ReadLine());
            perimeterHex = 6 * lengthHex;
            Console.WriteLine("Hexagon Perimeter = " + perimeterHex);
            areaHex = (3 * Math.Sqrt(3) / 2) * (lengthHex * lengthHex);
            Console.WriteLine(String.Format("Hexagon Area = {0:0.00}", areaHex));

        }
    }
}
