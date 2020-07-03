//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Assert = NUnit.Framework.Assert;
//TALHA BEĞENDİ

namespace N11Test
{
    [TestClass]
    public class ChromeAcilisN11
    {
        IWebDriver Webdriver;
        [OneTimeSetUp]
        public void N11Giris()
        {
            Webdriver = new ChromeDriver();
            Webdriver.Manage().Window.Maximize();
            Webdriver.Navigate().GoToUrl("https://www.n11.com/");
            Thread.Sleep(1000);
        }
        [Test, Category("N11 Test")]
        public void Senaryo_01_Giris()
        {
            n11Methods girisYap = new n11Methods(Webdriver);
            girisYap.MenuKapatButton();
            girisYap.GirisYap();
            girisYap.EmailGiris("mail@gmail.com");
            girisYap.SifreGiris("123456");
            girisYap.GirisYapButton();
            Assert.IsTrue(girisYap.GirisAssert_01_giris("Talha BEĞENDİ"), "Giris Yapildi");
        }
        [Test, Category("N11 Test")]
        public void Senaryo_02_UrunArama()
        {
            n11Methods urunArama = new n11Methods(Webdriver);
            urunArama.UrunArama("Samsung");
            urunArama.AraButton();
            Assert.IsTrue(urunArama.UrunAramaAssert_02_arama("Samsung"), "Samsung Arama Yapildi.");
        }
        [Test, Category("N11 Test")]
        public void Senaryo_03_Sayfa2()
        {
            n11Methods sayfa2 = new n11Methods(Webdriver);
            sayfa2.Sayfa2();
            Assert.IsTrue(sayfa2.Sayfa2Assert_03_sayfa2("2"), "Sayfa2'ye Ulasildi.");
        }
        [Test, Category("N11 Test")]
        public void Senaryo_04_FavoriEkleme()
        {
            n11Methods favoriEkleme = new n11Methods(Webdriver);
            favoriEkleme.UrunFavEkle();
            favoriEkleme.Hesabım();
            favoriEkleme.FavMenu();
            favoriEkleme.FavUrunlerList();
            Assert.IsTrue(favoriEkleme.UrunFavEkleAssert_04_favEkle(), "Favori Basariyla Eklendi.");
        }
        [Test, Category("N11 Test")]
        public void Senaryo_05_FavoriSilme()
        {
            n11Methods favoriSilme = new n11Methods(Webdriver);
            favoriSilme.FavSil1();
            favoriSilme.MenuKapatButton();
            Assert.IsTrue(favoriSilme.UrunFavSilAssert_05_favSil(),"Favori Basariyla Silindi.");
        }
    }
}