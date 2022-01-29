using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Logika
{
    class Kosarica
    {
        private Guid id;
        private Kupac kupac;
        private StatusKosarice status;
        private List<Artikl> stavke;

        public Kosarica(Kupac k)
        {
            id = Guid.NewGuid();
            kupac = k;
            status = StatusKosarice.Prazna;
            stavke = new List<Artikl>();
        }

        public void DodajArtikl(Artikl a)
        {
            stavke.Add(a);
        }
        public decimal IznosZaPlatiti()
        {
            decimal ukupno = 0;
            foreach (Artikl a in stavke)
                ukupno += a.Iznos();
            return ukupno;
        }

        public Kupac VratiKupca()
        {
            return kupac;
        }

        public List<Artikl> VratiStavke()
        {
            return stavke;
        }

        public Guid VratiId()
        {
            return id;
        }
    }
}
