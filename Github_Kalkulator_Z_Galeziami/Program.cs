﻿using System;
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
            Console.WriteLine(Kalkulator.Fibonacci(5));
            Console.WriteLine(Kalkulator.LiczbaCiaguArytmetycznego(2, 3, 10));
            Kalkulator.WypiszCiagArytmetyczny(2, 3, 10);
        }
    }
}
