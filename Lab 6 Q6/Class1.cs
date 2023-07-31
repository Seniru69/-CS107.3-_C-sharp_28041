using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Q6
{
    internal class Class1
    {
        public int[] arr;


        public void makeA(int s)
        {

            arr = new int[s];

            for (int a = 0; a < s; a++)
            {
                Console.Write("Enter the values: ");
                arr[a] = Convert.ToInt32(Console.ReadLine());
                if (a < arr.Length)
                {
                    a += 1;
                    arr[a] = 0;
                }

            }
        }

        public void printA()
        {
            for (int a = 0; a < arr.Length; a++)
            {
                Console.WriteLine($"Element [{a}]: {arr[a]}");
            }
        }
    }
}
