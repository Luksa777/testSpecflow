using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace RaptorMapsTestProject.Utilities
{
    [Binding]
    public class Hooks1
    {
        //declare webdriver
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //declare driver as chrome driver and maximize the window
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //close the browser after running BDD Scenario
            //driver.Quit();
        }
    }
}
