using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3PTPreScreening
{
   public class Constants
    {
        public const String FunctionalTesting = "Functional Testing";
        public const String Descriptions= "Search a YouTube Channel in Google";
        public const String ReportPath =   @"C:\Users\BinoySugatha\source\repos\I3PTPreScreening\I3PTPreScreening\ExtentReports\YoutubeModule.html";
        public const String ScreenShotPath = "C:\\Users\\BinoySugatha\\source\\repos\\I3PTPreScreening\\I3PTPreScreening\\ScreenShots\\Screenshot.jpeg";
        public const String TestStarted = "Test Started";
        public const String GoogleSearchTestCase = "Google Search TestCase";
        public const String SearchPage = "Search page lauched";
        public const String SearchPageDisplay = "Search Page displayed";
        public const String NavigateChannel = "Navigated to Channel Page";
        public const String SearchText = "World Of Mr Chef";
        public const String PassedText = "Test got passed";
        public const String SearchXPath = ".//*[@Name='q']";
        public const String XPathButton = ".//*[@Name='btnK']";
        public const String XPathSpan = "//span[contains(text(), 'World Of Mr Chef - YouTube')]";
        public const String XPathClass = ".//*[@class='style-scope ytd-channel-name']";
        public const String LaunchURL = "https://google.com/";
    }
}
