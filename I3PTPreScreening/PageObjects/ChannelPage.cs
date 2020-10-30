using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3PTPreScreening.PageObjects
{
    public class ChannelPage
    {
        IWebDriver driver;
        public ChannelPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = Constants.XPathClass)]
        public IWebElement ChannelName { get; set; }

        /// <summary>
        /// Launch the youtube channel page and fetch the channel name
        /// </summary>
        /// <returns>Channel Name</returns>
        public string getChannelName()
        {
           return ChannelName.Text;
        }

    }
}
