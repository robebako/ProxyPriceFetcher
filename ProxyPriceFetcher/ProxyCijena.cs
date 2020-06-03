using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPriceFetcher
{
    class ProxyCijena : ICijena
    {
        public ProxyCijena(KategorijaKorisnika kat,bool got)
        {
            kategorija = kat;
            gotovina = got;
        }
        public double prikaziCijenu(string artikl)
        {
            Cijena cijena = new Cijena();
            double price = cijena.prikaziCijenu(artikl);
            if (gotovina)
                price *= 0.95;
            switch (kategorija)
            {
                case KategorijaKorisnika.Registrirani:
                    return price *0.9;
                default:
                    return price;
            }
        }
        KategorijaKorisnika kategorija;
        bool gotovina;
    }
}
