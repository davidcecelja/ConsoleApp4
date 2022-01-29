using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Logika
{
    class Kupac
    {
        private string id;
        private string naziv;
        private string adresa;

        public Kupac(string _id, string _naziv, string _adresa)
        {
            id = _id;
            naziv = _naziv;
            adresa = _adresa;
        }

        public void PromijeniAdresu(string nova)
        {
            adresa = nova;
        }

        public string Opis()
        {
            return id + " / " + naziv + ", " + adresa;
        }

    }
}
