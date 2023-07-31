using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 values = new Class1();

            Console.WriteLine("Enter your radius of the circle: ");
            float ra = (float)Convert.ToDecimal(Console.ReadLine());

            float a = values.FindArea(ra);
            float c = values.FindCircumference(ra);

            Console.WriteLine("circle's area is: " + a);
            Console.WriteLine("circle's circumference is: " + c);

            Console.ReadKey();
        }
    }
}