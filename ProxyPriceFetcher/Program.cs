using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPriceFetcher
{
    enum KategorijaKorisnika
    {
        Registrirani,
        Neregistrirani
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string artikl = Console.ReadLine();
            ICijena cj = new ProxyCijena(KategorijaKorisnika.Registrirani, true);
            Console.WriteLine("Za artikl: {0} cijena je: {1}", artikl, cj.prikaziCijenu(artikl));
        }
    }
}
