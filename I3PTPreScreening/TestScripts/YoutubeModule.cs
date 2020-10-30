using I3PTPreScreening.BaseClass;
using I3PTPreScreening.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace I3PTPreScreening.TestScripts
{
    [TestFixture]
    public class YoutubeModule : BaseTest
    {
        /// <summary>
        /// This method is used to create the Extent Report and after execution of test script the report will be automtically created in the ExtentReport folder
        /// </summary>
        ExtentReports extentReport = null;
        ExtentTest test = null;
        [OneTimeSetUp]
        public void ExtendStart()
        {
            extentReport = new ExtentReports();
            var HtmlReport = new ExtentHtmlReporter(Constants.ReportPath);
            extentReport.AttachReporter(HtmlReport);
        }
        [OneTimeTearDown]
        public void ExtendClose()
        {
            extentReport.Flush();

        }

        /// <summary>
        /// This method is used to test the google search for a youtube channel called "World Of Mr Chef and launch the youtube channel and checking the correct channel is launched or not"
        /// </summary>

        [Test, Category(Constants.FunctionalTesting)]
        [Description(Constants.Descriptions)]
        public void GoogleSearchTestCase()
        {
            try
            {
                test= extentReport.CreateTest(Constants.GoogleSearchTestCase).Info(Constants.TestStarted);
                var SearchPage = new SearchPage(driver);
                test.Log(Status.Info, Constants.SearchPage);
                var ResultPage = SearchPage.NavigateToResultPage();
                test.Log(Status.Info,Constants.SearchPageDisplay);
                var ChannelPage = ResultPage.NavigateToChannel();
                test.Log(Status.Info,Constants.NavigateChannel);
                String ActualChannelName = ChannelPage.getChannelName();
                String ExpectedChannelName = Constants.SearchText;
                Assert.IsTrue(ActualChannelName.Equals(ExpectedChannelName));
                test.Log(Status.Pass, Constants.PassedText);
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                // If the error occur the screen shot will capture in the ScreenShot folder
                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
                Screenshot screenShot = takesScreenshot.GetScreenshot();
                screenShot.SaveAsFile(Constants.ScreenShotPath, ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }

            }
            
        }

    }
}
