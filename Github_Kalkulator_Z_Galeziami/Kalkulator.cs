using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Kalkulator_Z_Galeziami
{
    public static class Kalkulator
    {
        public static int Kwadrat(int a)
        {
            return a * a;
        }

        public static int Szescian(int a)
        {
            return Kwadrat(a) * a;
        }

        public static int SzescianPlusKwadrat(int a)
        {
            return Szescian(a) + Kwadrat(a);
        }

        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            int c = a + b;
            if (n < 3)
            {
                return a;
            }
            for (int i = 3; i < n; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }

        public static int LiczbaCiaguArytmetycznego(int an, int r, int n)
        {
            for (int i = 0; i < n; i++)
            {
                an += r;
            }
            return an;
        }
    }
}
