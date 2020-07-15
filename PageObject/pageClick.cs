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
        IWebElement element;
        public n11Methods(IWebDriver driver)
        {
            this.webDriver = driver;
        }
        public void MenuKapatButton()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.menuKapatButton)).Click();
        }
        public void GirisYap()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.girisYap)).Click();
        }
        public void EmailGiris(string userEmailGiris)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.emailGiris)).SendKeys(userEmailGiris);
        }
        public void SifreGiris(string userSifreGiris)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sifreGiris)).SendKeys(userSifreGiris);
        }
        public void GirisYapButton()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.girisYapButton)).Click();
            Thread.Sleep(20080);
        }
        public void UrunArama(string userUrunArama)
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunArama)).SendKeys(userUrunArama);
        }
        public void AraButton()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.araButton)).Click();
        }
        public void Sayfa2()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sayfa2)).Click();
        }
        public void UrunFavEkle()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunFavEkle)).Click();
        }
        public void Hesabım()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.hesabım)).Click();
        }
        public void FavMenu()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.favMenu)).Click();
        }
        public void FavUrunlerList()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.favUrunlerList)).Click();
        }
        public void FavSil1()
        {
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.favSil1)).Click();
        }

        //ASSERT

        public bool GirisAssert_01_giris(string girisText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.girisAssert_01_giris));
            return element.Text == girisText;
        }
        public bool UrunAramaAssert_02_arama(string aramaText)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunAramaAssert_02_arama));
            return element.Text == aramaText;
        }
        public bool Sayfa2Assert_03_sayfa2(string sayfa2Text)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sayfa2Assert_03_sayfa2));
            return element.Text == sayfa2Text;
        }
        public bool UrunFavEkleAssert_04_favEkle()
        {
            Thread.Sleep(350);
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
            Thread.Sleep(350);
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
