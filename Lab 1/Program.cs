using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program c = new Program();
            c.q1();
            c.q2();
            c.q3();
            c.q4();
        }

        void q1()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your assigned batch: ");
            string batch = Console.ReadLine();
            Console.WriteLine("Hi, I'm {0}, I belong to {1} batch", name, batch);
        }

        void q2()
        {
            Console.Write("Enter the radius: ");
            float r = float.Parse(Console.ReadLine());
            Console.Write("The area of the circle = {0}", 3.14 * r * r);

        }

        void q3()
        {
            Console.Write("Enter your first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your second number:  ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Total is {0}", n1 + n2);
        }

        void q4()
        {
            Console.Write("Enter your salary: ");
            float s = float.Parse(Console.ReadLine());
            Console.Write("Enter your assigned tax rate: ");
            float t = float.Parse(Console.ReadLine());

            float tp = s * t / 100;
            float r = s - tp;

            Console.Write("Your confirmed salary is = {0}", r);

        }
    }
}