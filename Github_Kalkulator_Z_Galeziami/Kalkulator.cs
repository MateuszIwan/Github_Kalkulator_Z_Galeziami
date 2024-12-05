using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Kalkulator_Z_Galeziami
{
    public static partial class Kalkulator
    {
        public static int Kwadrat(int a)
        {
            return a * a;
        }

        public static int Szescian(int a)
        {
            return Kwadrat(a) * a;
        }
    }
}
