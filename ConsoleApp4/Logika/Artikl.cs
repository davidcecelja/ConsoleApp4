using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Logika
{
    class Artikl
    {
        private string opis;
        private int kolicina;
        private decimal cijena;

        public Artikl(string _opis, int _kol, decimal _cijena)
        {
            opis = _opis;
            kolicina = _kol;
            cijena = _cijena;
        }

        public decimal Iznos()
        {
            return Math.Round(kolicina * cijena,2);
        }

        public string Opis()
        {
            string s = String.Format("{0,-20}{1,10}{2,10}{3,10}",
                opis, cijena, kolicina, Iznos());
            return s;
        }
    }
}
