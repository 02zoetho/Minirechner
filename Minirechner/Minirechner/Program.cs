using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Subbtractions Methode
            int a = 100;
            int b = 10;

            Subtrahiere(a,b);
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            Zahl1 = Zahl1 - Zahl2;
            return Zahl1;
        }
    }
}
