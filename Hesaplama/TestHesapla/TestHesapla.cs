using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace TestHesapla
{
    [TestClass]
    public class TestHesapla
    {
        [TestMethod]

        [Fact]
        public void Topla()
        {
            Hesaplama.clsHesaplama _hesap=new Hesaplama.clsHesaplama();
            int sonuc = _hesap.topla(20, 30);
            //beklenilen=50
            Assert.Equals(50, sonuc);
        }
        [Fact]
        public void Cikar()
        {
            Hesaplama.clsHesaplama _hesap = new Hesaplama.clsHesaplama();
            int sonuc = _hesap.cikar(30, 20);
            //beklenilen=10
            Assert.Equals(10, sonuc);
        }
        [Fact]
        public void Bol()
        {
            Hesaplama.clsHesaplama _hesap = new Hesaplama.clsHesaplama();
            int sonuc = _hesap.topla(50, 25);
            //beklenilen=2
            Assert.Equals(2, sonuc);
        }
        [Fact]
        public void Carp()
        {
            Hesaplama.clsHesaplama _hesap = new Hesaplama.clsHesaplama();
            int sonuc = _hesap.topla(50, 50);
            //beklenilen=2500
            //cıkan sonuc 100
            Assert.Equals(2500, sonuc);
        }
    }
}
