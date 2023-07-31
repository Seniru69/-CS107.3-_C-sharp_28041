using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    public class GetDigits
    {
        protected double n1;
        protected double n2;

        public GetDigits()
        {
            Console.WriteLine("Enter your first Number:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second Number:");
            n2 = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Addition : GetDigits
    {
        public double CalSum()
        {
            return n1 + n2;
        }
    }

    public class Substraction : GetDigits
    {
        public double CalDiff()
        {
            return n1 - n2;
        }
    }

    public class Multiplication : GetDigits
    {
        public double CalPro()
        {
            return n1 * n2;
        }
    }

    public class Division : GetDigits
    {
        public double CalQuo()
        {
            if (n2 != 0)
            {
                return n1 / n2;
            }
            else
            {
                Console.WriteLine("zero is not allowed.");
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Addition sum = new Addition();
            double sumResult = sum.CalSum();

            Substraction sub = new Substraction();
            double differenceResult = sub.CalDiff();

            Multiplication mul = new Multiplication();
            double productResult = mul.CalPro();

            Division div = new Division();
            double quotientResult = div.CalQuo();

            Console.WriteLine($"Sum: {sumResult}");
            Console.WriteLine($"Difference: {differenceResult}");
            Console.WriteLine($"Product: {productResult}");
            Console.WriteLine($"Quotient: {quotientResult}");

            Console.ReadLine();
        }
    }
}
