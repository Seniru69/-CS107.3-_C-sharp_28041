using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2cs convert = new Class2cs();

            Console.WriteLine("Enter the distance in kilometer: ");
            float km = (float)Convert.ToDecimal(Console.ReadLine());

            float m = convert.KilometerTometer(km);
            Console.WriteLine("The distance in Kilometer is: " + m);


            Console.ReadKey();
        }
    }
}
