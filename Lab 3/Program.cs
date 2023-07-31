using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.q1();
            p.q2();
            p.q3();
            p.q4();
        }

        void q1()
        {
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("It's even");
            }
            else
            {
                Console.WriteLine("It's odd");
            }
        }
        void q2()
        {
            Console.WriteLine("Enter a word: ");
            string str = Console.ReadLine();
            int vc = 0;
            for (int a = 0; a < str.Length; a++)
            {
                char l = str[a];

                if (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u' || l == 'A' || l == 'E' || l == 'I' || l == 'O' || l == 'U')
                {
                    vc++;
                }
            }
            Console.WriteLine("The number of vowels in your word are:{0}.", vc);
        }

        void q3()
        {
            Console.WriteLine("Enter your number:");
            int n = int.Parse(Console.ReadLine());

            int t = 0;
            while (n > 0)
            {
                int d = n % 10;
                t += d;
                n /= 10;
            }
            Console.WriteLine("Total is: {0}", t);

        }

        void q4()
        {
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());

            int t = 0;

            while (n > 0)
            {
                int d = n % 10;

                if (n % 2 == 1)
                {
                    t += d;
                }
                n /= 10;
            }
            Console.WriteLine("Sum of the Digit = {0}", t);
        }
    }
}

