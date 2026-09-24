using System;
using System.Collections.Generic;
using System.Text;

namespace _03_FeludefinialasEsListak
{
    internal class Jatekos
    {
        private string nev;
        private int szint;
        public string Nev { get; set; }
        public int Szint
        {
            get
            {
                return szint;
            }
            set
            {
                if (value < 1)
                {
                    szint = 1;
                }
                else if (value > 100)
                {
                    szint = 100;
                }
                else
                {
                    szint = value;
                }
            }
        }
    }  
}
