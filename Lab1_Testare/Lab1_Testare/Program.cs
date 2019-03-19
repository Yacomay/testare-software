using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab1_Testare
{
    class Program
    {
        static void Main()
        {
            Test1 test = new Test1();
            test.StartBrowser();
            test.Test();
            test.CloseBrowser();
        }
    }
}
