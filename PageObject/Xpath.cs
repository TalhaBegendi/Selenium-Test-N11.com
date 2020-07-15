//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
//TALHA BEĞENDİ

namespace N11Test
{
    public static class kontrolOzellikleri
    {   //ASSERT
        [CacheLookup] public static By girisAssert_01_giris = By.XPath("//a[@class='menuLink user'][text()='Talha BEĞENDİ']");
        [CacheLookup] public static By urunAramaAssert_02_arama = By.XPath("//div[@class='resultText ']/h1[text()='Samsung']");
        [CacheLookup] public static By sayfa2Assert_03_sayfa2 = By.XPath("//div[@class='pagination']/a[3][text()='2']");
        [CacheLookup] public static By urunFavEkleAssert_04_favEkle = By.XPath("//div[@id='p-418914032']");
        [CacheLookup] public static By urunFavSilAssert_05_favSil = By.XPath("//div[@id='p-418914032']");

        //XPATH
        [CacheLookup] public static By menuKapatButton = By.ClassName("closeBtn");
        [CacheLookup] public static By girisYap = By.ClassName("btnSignIn");
        [CacheLookup] public static By emailGiris = By.Id("email");
        [CacheLookup] public static By sifreGiris = By.Id("password");
        [CacheLookup] public static By girisYapButton = By.Id("loginButton");
        [CacheLookup] public static By urunArama = By.Id("searchData");
        [CacheLookup] public static By araButton = By.ClassName("iconSearch");
        [CacheLookup] public static By sayfa2 = By.XPath("//div[@class='pagination']/a[2]");
        [CacheLookup] public static By urunFavEkle = By.XPath("//div[@data-position='31']/div[1]/span");
        [CacheLookup] public static By hesabım = By.ClassName("myAccount");
        [CacheLookup] public static By favMenu = By.XPath("//div[@class='accNav']/ul/li[5]");
        [CacheLookup] public static By favUrunlerList = By.XPath("//li[@class='wishGroupListItem favorites']/div/a[1]");
        [CacheLookup] public static By favSil1 = By.XPath("//div[@id='p-418914032']/div[3]/span");

    }
}
