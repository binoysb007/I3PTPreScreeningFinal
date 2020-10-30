using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;
namespace I3PTPreScreening.BaseClass
{
   public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Launch()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = Constants.LaunchURL;
           Thread.Sleep(3000);
        }

        [TearDown]
        public void Close()
        {
           driver.Quit();
        }
    }
}
