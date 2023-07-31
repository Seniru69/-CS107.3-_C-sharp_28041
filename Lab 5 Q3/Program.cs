using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no1, no2, ch;

            Class1 calculate = new Class1();


            Console.Write("Choose 01 for Addition\n" +
                "Choose 02 for Substraction\n" +
                "Choose 03 for Division\n" +
                "CHoose 04 for Multiplication\n");

            ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number 1: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number 2: ");
            no2 = Convert.ToInt32(Console.ReadLine());


            if (ch == 01)
            {
                Console.WriteLine("Total: " + calculate.addition(no1, no2));
            }
            else if (ch == 02)
            {
                Console.WriteLine("Difference: " + calculate.substraction(no1, no2));
            }
            else if (ch == 3)
            {
                Console.WriteLine("Division: " + calculate.division(Convert.ToDouble(no1), Convert.ToDouble(no2)));
            }
            else if (ch == 4)
            {
                Console.WriteLine("Multiplication: " + calculate.multiplication(no1, no2));
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadKey();
        }
    }
}
