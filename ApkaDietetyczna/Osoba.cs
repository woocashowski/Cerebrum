using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApkaDietetyczna
{
    public class Osoba
    {

        public int wiek { get; set; }
        public int wzrost { get; set; } 
        public int waga { get; set; }
       public bool plec;
        public Osoba(int wiek=0, int wzrost=0, int waga=0, bool plec=false)
        {
            this.wiek = wiek;
            this.wzrost = wzrost;
            this.waga = waga;
            this.plec = plec;

        }


    }
}