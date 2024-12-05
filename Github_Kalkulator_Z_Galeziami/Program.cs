using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_Kalkulator_Z_Galeziami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kalkulator.Kwadrat(5));
            Console.WriteLine(Kalkulator.Szescian(5));
            Console.WriteLine(Kalkulator.SzescianPlusKwadrat(5));
        }
    }
}
