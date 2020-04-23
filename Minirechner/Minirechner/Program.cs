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
            int a = 100;
            int b = 10;

            Dividiere(a, b);
          

        }

        static int Dividiere(int Zahl1, int Zahl2)
        {// Addier Methode

            Zahl1 = Zahl1 / Zahl2;
            return Zahl1;
            
        }
    }
}
