using Harrods_Project.FrameworkLayer.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harrods_Project.FrameworkLayer.TestBase
{
    public class BasePage
    {
        public static IWebDriver Driver;

        public void LaunchBrowser()
        {
            var PathtoFile = PathHelper.GetPathToFile("EnvironmentVariables.json", @"FrameworkLayer\Resource");
            var BrowserToLaunch = VariableValueReader.ReadVariableValue(PathtoFile, "browser");
            switch(BrowserToLaunch.ToLower())
            {
                case "chrome":
                    Driver = new ChromeDriver();
                    break;
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "edge":
                    Driver = new EdgeDriver();
                    break;
                default:
                    Console.WriteLine( "The browser type specified is not supported by the framework");
                    break;
            }

             Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);
            Driver.Manage().Window.Maximize();
        }


    }
}
