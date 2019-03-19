using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Lab1_Testare
{
    class Test1
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Cornel\\Desktop\\Chrome Driver");
        }

        [Test]
        public void Test()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                driver.Url = "file:///C:/Uni/Repository/testare-software/Lab1_Testare/Lab1_Testare/Webpage.html";
                driver.FindElement(By.Id("loginName")).SendKeys("test");
                driver.FindElement(By.Id("loginPass")).SendKeys("run");
                driver.FindElement(By.Id("btnLogin")).Click();
                wait.Until(wt => wt.FindElement(By.Id("secret")));
                Console.WriteLine("Login Succesful");
                Console.ReadKey();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error message: ", exc.Message);
                return;
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
