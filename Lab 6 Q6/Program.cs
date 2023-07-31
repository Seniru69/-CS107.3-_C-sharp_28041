using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManaging
{
    public class ArrayManager
    {
        public void ProcessArray(int s)
        {
            int[] userArr = new int[s * 2];

            for (int a = 0; a < s; a++)
            {
                Console.WriteLine($"Enter value {a + 1}:");
                userArr[a * 2] = Convert.ToInt32(Console.ReadLine());
                userArr[a * 2 + 1] = 0;
            }

            Console.WriteLine("Array Values:");
            foreach (int value in userArr)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int s = Convert.ToInt32(Console.ReadLine());

            ArrayManager arrayHandler = new ArrayManager();
            arrayHandler.ProcessArray(s);

            Console.ReadLine();
        }
    }
}

