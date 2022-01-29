using ConsoleApp4.Logika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupac marko = new Kupac("00001", "Marko Marković",
                "Mihovljanska 123, 40000 ČAKOVEC");
            marko.PromijeniAdresu("Partzinska 73, 42000 VARAŽDIN");
            Artikl samsungS21Plus = 
                new Artikl("Samsung S21+", 2, (decimal)9999.99);
            Artikl maskica =
                new Artikl("Maskica za S21+", 3, (decimal)159.62);
            Kosarica markova = new Kosarica(marko);
            markova.DodajArtikl(samsungS21Plus);
            markova.DodajArtikl(maskica);
            markova.DodajArtikl(new Artikl("USB kabel", 1, 91));

            // ispisati racun
            Console.WriteLine(markova.VratiId().ToString());
            Console.WriteLine(markova.VratiKupca().Opis());
            foreach (Artikl a in markova.VratiStavke())
                Console.WriteLine(a.Opis());
            Console.WriteLine("Platiti: {0}", markova.IznosZaPlatiti());

        }
    }
}
