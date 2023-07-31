using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Class1 arrMethods = new Class1();

            for (int s = 1; s <= arr.Length; s++)
            {
                Console.WriteLine("Enter value for index " + s + ":");
                arr[s] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Maximum Value: " + arrMethods.Mx(arr));
            Console.WriteLine("Minimum Value: " + arrMethods.Mn(arr));
            Console.WriteLine("Average Value: " + arrMethods.Aveg(arr));

        }
    }
}
