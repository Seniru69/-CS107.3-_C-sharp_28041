using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Class1
    {
        static double p = 22 / 7;
        public float FindArea(float r)
        {
            float a = (float)p * r * r;
            return a;
        }

        public float FindCircumference(float r)
        {

            float c = (float)p * 2 * r;
            return c;
        }
    }
}