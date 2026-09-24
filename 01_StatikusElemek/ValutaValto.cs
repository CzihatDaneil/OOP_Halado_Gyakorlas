using System;
using System.Collections.Generic;
using System.Text;

namespace _01_StatikusElemek
{
    public static class ValutaValto
    {
        public const double EUR_HUF = 395.5;
        public const double USD_HUF = 360.0;
        private static int osszesAtvaltas = 0;
        public static double EurToHuf(double eur) 
        {
            osszesAtvaltas++;
            return eur * EUR_HUF;
        }
        public static double UsdToHuf(double usd) 
        { 
            osszesAtvaltas++;
            return usd * USD_HUF;
        }

        public static int GetOsszesAtvaltas()
        {
            return osszesAtvaltas;
        
        }
    }
}
