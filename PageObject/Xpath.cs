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
//TALHA BEĞENDİ

namespace N11Test
{
    public static class kontrolOzellikleri
    {   //ASSERT
        public static By girisAssert_01_giris = By.XPath(".//*[@class='menuLink user'][text()='Talha BEĞENDİ']");
        public static By urunAramaAssert_02_arama = By.XPath(".//*[@class='resultText ']/h1[text()='Samsung']");
        public static By sayfa2Assert_03_sayfa2 = By.XPath(".//*[@class='pagination']/a[3][text()='2']");
        public static By urunFavEkleAssert_04_favEkle = By.XPath(".//div[@id='p-436748644']");
        public static By urunFavSilAssert_05_favSil = By.XPath(".//div[@id='p-436748644']");
        //public static By urunFavSilAssert_05_favSil = By.XPath(".//*[@class='content']/span[2][text()='Ürününüz listeden silindi.']");
        
        //XPATH
        public static By menuKapatButton = By.ClassName("closeBtn");
        public static By girisYap = By.ClassName("btnSignIn");
        public static By emailGiris = By.Id("email");
        public static By sifreGiris = By.Id("password");
        public static By girisYapButton = By.Id("loginButton");
        public static By urunArama = By.Id("searchData");
        public static By araButton = By.ClassName("iconSearch");
        public static By sayfa2 = By.XPath(".//*[@class='pagination']/a[2]");
        public static By urunFavEkle = By.XPath(".//*[@data-position='31']/div[1]/span"); 
        public static By hesabım = By.ClassName("myAccount");
        public static By favMenu = By.XPath(".//*[@class='accNav']/ul/li[5]");
        public static By favUrunlerList = By.XPath("//*[@class='listItemWrap']/a");
        public static By favSil1 = By.XPath(".//*[@data-ctgid='12']/div[3]/span");

    }
}
