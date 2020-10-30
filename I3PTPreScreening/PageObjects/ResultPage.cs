using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I3PTPreScreening.PageObjects
{
   public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = Constants.XPathSpan)]
        public IWebElement ChannelNameLinkText { get; set; }

        /// <summary>
        /// From the Search result page to Youtube channel page
        /// </summary>
        /// <returns>passing the driver to the Channel page</returns>

        public ChannelPage NavigateToChannel()
        {
            Thread.Sleep(3000);
            ChannelNameLinkText.Click();
            return new ChannelPage(driver);
        }
    }
}
