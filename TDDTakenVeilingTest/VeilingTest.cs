using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenVeiling;

namespace TDDTakenVeilingTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void NogGeenBodEnHoogsteBedragIsNul()
        {
            Assert.AreEqual(0m, new Veiling().HoogsteBod);
        }

        [TestMethod]
        public void EersteBodIsHoogsteBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(1000m);
            Assert.AreEqual(1000m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void MeerdereBiedingenWaarnaHoogsteBodGelijkIsAanBedragVanDitBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(1000m);
            veiling.DoeBod(2000m);
            veiling.DoeBod(750m);
            Assert.AreEqual(2000m, veiling.HoogsteBod);
        }
    }
}
