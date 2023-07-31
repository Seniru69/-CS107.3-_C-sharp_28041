using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program n = new Program();
            n.q1();
            n.q2();
            n.q3();
            n.q4();
            n.q5();
        }

        void q1()
        {
            Console.Write("Enter your first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Total= {0} ", n1 + n2);
        }

        void q2()
        {
            Console.Write("Enter your first number: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Addition= {0}", n1 + n2);
            Console.Write("Substraction= {0}", n1 - n2);
            Console.Write("Multiplication= {0}", n1 * n2);
            Console.Write("Division{0}", n1 / n2);
        }

        void q3()
        {
            Console.Write("Enter your radius of the circle: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Area = {0}", 3.14 * r * r);
            Console.Write("Circumference = {0}", 2 * 3.14 * r);

        }

        void q4()
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.Write("It's even");
            }
            else
            {
                Console.Write("It's odd");
            }
        }

        void q5()
        {
            int[] n = new int[10];

            for (int a = 0; a < n.Length; a++)
            {
                Console.Write("Enter the value {0} : ", a);
                n[a] = int.Parse(Console.ReadLine());
            }

            for (int s = 0; s < n.Length; s++)
            {
                if (n[j] % 2 == 0)
                {
                    Console.WriteLine("The number {0} is Even number", s);
                }
                else
                {
                    Console.WriteLine("The number {0} is ODD number", s);
                }
            }
        }
    }
}
   