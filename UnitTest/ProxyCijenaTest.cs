using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProxyPriceFetcher.UnitTest
{
    [TestClass]
    public class ProxyCijenaTest
    {
        [TestMethod]
        public void PrikaziCijenuReturns6point12ForArticleMlijekoForRegisteredUserWithNonCashPayment()
        {
            ProxyCijena pc = new ProxyCijena(KategorijaKorisnika.Registrirani, false);
            Assert.AreEqual(6.12, pc.prikaziCijenu("Mlijeko"));
        }
        [TestMethod]
        public void PrikaziCijenuReturns5point814ForArticleMlijekoForRegisteredUserWithCashPayment()
        {
            ProxyCijena pc = new ProxyCijena(KategorijaKorisnika.Registrirani, true);
            Assert.AreEqual(5.814, pc.prikaziCijenu("Mlijeko"));
        }
        [TestMethod]
        public void PrikaziCijenuReturns6point46ForArticleMlijekoForNonRegisteredUserWithCashPayment()
        {
            ProxyCijena pc = new ProxyCijena(KategorijaKorisnika.Neregistrirani,true);
            Assert.AreEqual(6.46, pc.prikaziCijenu("Mlijeko"));
        }
        [TestMethod]
        public void PrikaziCijenuReturns6point80ForArticleMlijekoForNonRegisteredUserWithNonCashPayment()
        {
            ProxyCijena pc = new ProxyCijena(KategorijaKorisnika.Neregistrirani, false);
            Assert.AreEqual(6.80, pc.prikaziCijenu("Mlijeko"));
        }
    }
}
