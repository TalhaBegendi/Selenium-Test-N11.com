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
using System.Threading;
using Assert = NUnit.Framework.Assert;
//TALHA BEĞENDİ

namespace N11Test
{
    public class n11Methods
    {
        IWebDriver webDriver;
        public n11Methods(IWebDriver driver)
        {
            this.webDriver = driver;
        }
        public void MenuKapatButton()
        {
            webDriver.FindElement(kontrolOzellikleri.menuKapatButton).Click();
            Thread.Sleep(1080);
        }
        public void GirisYap()
        {
            webDriver.FindElement(kontrolOzellikleri.girisYap).Click();
            Thread.Sleep(1200);
        }
        public void EmailGiris(string userEmailGiris)
        {
            webDriver.FindElement(kontrolOzellikleri.emailGiris).Clear();
            webDriver.FindElement(kontrolOzellikleri.emailGiris).SendKeys(userEmailGiris);
            Thread.Sleep(300);
        }
        public void SifreGiris(string userSifreGiris)
        {
            webDriver.FindElement(kontrolOzellikleri.sifreGiris).Clear();
            webDriver.FindElement(kontrolOzellikleri.sifreGiris).SendKeys(userSifreGiris);
            Thread.Sleep(800);
        }
        public void GirisYapButton()
        {
            webDriver.FindElement(kontrolOzellikleri.girisYapButton).Click();
            Thread.Sleep(1080);
        }
        public void UrunArama(string userUrunArama)
        {
            webDriver.FindElement(kontrolOzellikleri.urunArama).Clear();
            webDriver.FindElement(kontrolOzellikleri.urunArama).SendKeys(userUrunArama);
            Thread.Sleep(390);
        }
        public void AraButton()
        {
            webDriver.FindElement(kontrolOzellikleri.araButton).Click();
            Thread.Sleep(3050);
        }
        public void Sayfa2()
        {
            webDriver.FindElement(kontrolOzellikleri.sayfa2).Click();
            Thread.Sleep(1520);
        }
        public void UrunFavEkle()
        {   webDriver.FindElement(kontrolOzellikleri.urunFavEkle).Click();
            Thread.Sleep(1400); 
        }
        public void Hesabım()
        {
            webDriver.FindElement(kontrolOzellikleri.hesabım).Click();
            Thread.Sleep(1420);
        }
        public void FavMenu()
        {
            webDriver.FindElement(kontrolOzellikleri.favMenu).Click();
            Thread.Sleep(1400);
        }
        public void FavUrunlerList()
        {
            webDriver.FindElement(kontrolOzellikleri.favUrunlerList).Click();
            Thread.Sleep(1500);
        }
        public void FavSil1()
        {
            webDriver.FindElement(kontrolOzellikleri.favSil1).Click();
            Thread.Sleep(1000);
        }

            //ASSERT

        public bool GirisAssert_01_giris(string girisText)
        {
            return webDriver.FindElement(kontrolOzellikleri.girisAssert_01_giris).Text == girisText;
        }
        public bool UrunAramaAssert_02_arama(string aramaText)
        {
            return webDriver.FindElement(kontrolOzellikleri.urunAramaAssert_02_arama).Text == aramaText;
        }
        public bool Sayfa2Assert_03_sayfa2(string sayfa2Text)
        {
            return webDriver.FindElement(kontrolOzellikleri.sayfa2Assert_03_sayfa2).Text == sayfa2Text;
        }
        public bool UrunFavEkleAssert_04_favEkle()
        {
            if (webDriver.FindElements(kontrolOzellikleri.urunFavEkleAssert_04_favEkle).Count == 1)
            {
                return true;
            }
            else
            {
                return false;}
        }
        public bool UrunFavSilAssert_05_favSil()
        {
            if (webDriver.FindElements(kontrolOzellikleri.urunFavSilAssert_05_favSil).Count == 0)
            {
                return true;
            }
            else
            {
                return false;}
        }
    }
}