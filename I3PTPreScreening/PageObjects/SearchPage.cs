using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using I3PTPreScreening.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace I3PTPreScreening.PageObjects
{
   public class SearchPage :BaseTest
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }



        [FindsBy(How = How.XPath, Using = Constants.SearchXPath)]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = Constants.XPathButton)]
        public IWebElement SearchButton { get; set; }

        /// <summary>
        /// Once the URL is loaded and the entered the text to be searched and then navigated to the search result page
        /// </summary>
        /// <returns>Passing the driver to the result page</returns>
        public ResultPage NavigateToResultPage()
        {
            Thread.Sleep(500);
            SearchTextBox.SendKeys(Constants.SearchText);
            SearchButton.Click();
            return new ResultPage(driver);
        }

    }

    }

