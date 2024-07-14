using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExample.Tests
{
    internal class GoogleSearchTest
    {
     private IWebDriver driver;

        public GoogleSearchTest() { }

        [SetUp]
        public void Setup()
        {
            string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\קורס אוטומציה\\tovi-kot";
            driver = new ChromeDriver(path + @"\drivers\");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            //1
            driver.Navigate().GoToUrl("https://www.google.com");
            
            //2
            Assert.AreEqual("Google", driver.Title);

            //3

            GoogleHomePage.Search("Selenium WebDriver");
            //4
            //searchBox.SendKeys("Selenium WebDriver");

            ////5
            //searchBox.Submit();

            //6
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
            Assert.IsTrue(driver.Title.Contains("Selenium WebDriver") );

            //7
            IReadOnlyCollection<IWebElement> results = driver.FindElements(By.Name("h3"));
            
            Assert.IsTrue(results.Any());

            //8
            results.First().Click();

            //9
            Assert.AreEqual("WebDriver", driver.Title);

            //10
            driver.Navigate().Back();

            //11
            Assert.AreEqual("Selenium WebDriver", searchBox.GetAttribute("value"));






        }
        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }


    }
}
