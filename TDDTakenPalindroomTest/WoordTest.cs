using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDTakenPalindroom;

namespace TDDTakenPalindroomTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void NegenIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("negen").IsPalindroom());
        }
        [TestMethod]
        public void ZevenIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("zeven").IsPalindroom());
        }
        [TestMethod]
        public void LegeStringIsEenPalindroom()
        {
            Assert.IsTrue(new Woord(string.Empty).IsPalindroom());
        }
        [TestMethod]
        public void Slechts1CijferAlsStringIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("1").IsPalindroom());
        }
        [TestMethod]
        public void Slechts1LetterAlsStringIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("e").IsPalindroom());
        }
        [TestMethod]
        public void AlsStringIs66EenPalindroom()
        {
            Assert.IsTrue(new Woord("66").IsPalindroom());
        }
        [TestMethod]
        public void AlsStringIs67GeenPalindroom()
        {
            Assert.IsFalse(new Woord("67").IsPalindroom());
        }
    }
}
