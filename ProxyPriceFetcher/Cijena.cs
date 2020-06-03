using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPriceFetcher
{
    class Cijena : ICijena
    {
        public double prikaziCijenu(string artikl)
        {
            return cjenik[artikl];
        }
        private Dictionary<string, double> cjenik = new Dictionary<string, double>
        {
            {"Kruh",10.99},
            {"Mlijeko",6.80},
            {"Jogurt",5.65}
        };
    }
}
