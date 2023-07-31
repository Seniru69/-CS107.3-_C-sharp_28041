using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Q5
{
    internal class Class1
    {
   public int Mx(int[] a)
        {
            int mx;
            mx = 0;
            for(int s = 0; s < a.Length; s++)
            {
                if (a[s] > mx)
                {
                    mx = a[s];
                }
            }
            return mx;
        }

        public int Mn(int[] a)
        {
            int mn;
            mn = 0;
            for(int s=0; s < a.Length; s++)
            {
                if (a[s] < mn)
                {
                    mn = a[s];
                }
            }
            return mn;
        }

        public double Aveg(int[] a)
        {
            double aveg;
            int total=0;
            for(int s= 0; s < a.Length;s++)
            {
                total += a[s];
            }
            aveg = total / a.Length;
            return aveg;
        }
    }
}
