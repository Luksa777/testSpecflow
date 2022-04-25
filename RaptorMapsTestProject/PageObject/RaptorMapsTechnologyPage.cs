using FluentAssertions;
using OpenQA.Selenium;
using RaptorMapsTestProject.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaptorMapsTestProject.PageObject
{
    class RaptorMapsTechnologyPage
    {
        IWebDriver driver;
        public RaptorMapsTechnologyPage()
        {
            driver = Hooks1.driver;
        }

        public IWebElement technologyButton => driver.FindElement(By.XPath("//a[@href='https://raptormaps.com/rmtechnology/']"));

        public IWebElement techPageText => driver.FindElement(By.XPath("//span[text()='Robust software built for solar performance optimization.']"));
        public IWebElement apiIntegrationSectionTitle => driver.FindElement(By.XPath("//h1[contains(text(),'API Integration')]"));
        public IWebElement apiIntegrationSectionText => driver.FindElement(By.XPath("(//*[@id='tech-api']//p)[2]"));
        public IWebElement apiIntegrationSectionPhoto => driver.FindElement(By.XPath("//*[@src='https://raptormaps.com/wp-content/uploads/2019/09/Raptor-Maps-API.png']"));
        public IWebElement KnowledgeHubButton => driver.FindElement(By.XPath("//*[@class='et_pb_button et_pb_button_1 et_pb_bg_layout_light']"));
        public IWebElement apiIntegrationSection => driver.FindElement(By.XPath("//*[@id='tech-api']"));
        public IWebElement solfarFarmEndpoint => driver.FindElement(By.XPath("(//*[@href='/reference/solar-farm-endpoints'])[1]/.."));
        public IWebElement apiV2SolarFarm => driver.FindElement(By.XPath("(//*[@href='/reference/apiv2solar_farms'])[1]"));
        public IWebElement yourRequestHistoy => driver.FindElement(By.XPath("//*[@class='Reference-section']"));
        public IWebElement queryParams => driver.FindElement(By.XPath("//*[@id='form-apiv2solarFarms']"));
        public IWebElement Responses => driver.FindElement(By.XPath("//*[@class='Flex Flex_row APIResponseSchemaPicker-option3CU8y1saVb8O APIResponseSchemaPicker-option_hasContent2GpfP03Ra7oM ']/.."));
        public IWebElement WarningText1 => driver.FindElement(By.XPath("//*[@data-testid='RDMD']//p"));
        public IWebElement WarningText2 => driver.FindElement(By.XPath("//*[@data-testid='RDMD']//p//br"));
        public IWebElement authenticationToken => driver.FindElement(By.XPath("//*[@id='APIAuth-Authentication-Token']"));
        public IWebElement orgIdField => driver.FindElement(By.XPath("//*[@id='query-apiv2solarFarms_org_id']"));
        public IWebElement tryItButton => driver.FindElement(By.XPath("//*[@type='button' and text() = 'Try It!']"));
        public IWebElement x3 => driver.FindElement(By.XPath("//*[@type='button' and text() = 'Try It!']"));
        public IWebElement lastUUID => driver.FindElement(By.XPath("(//*[@class='cm-string'])[last()]"));
        public IWebElement statusCode200 => driver.FindElement(By.XPath("(//*[@aria-label='200'])[2]"));
        public IWebElement statusCode403 => driver.FindElement(By.XPath("//*[@class=' HTTPStatus HTTPStatus_4']"));
        public IWebElement statusCode401 => driver.FindElement(By.XPath("(//*[@aria-label='401'])[1]"));
        public IWebElement statusCode400 => driver.FindElement(By.XPath("(//*[@aria-label='400'])[1]"));
        public IWebElement statusCode500 => driver.FindElement(By.XPath("(//*[@aria-label='500'])[1]"));




        public void NavigateToRaptorMaps()
        {
            
            driver.Navigate().GoToUrl("https://raptormaps.com/jobs/");
        }

        public void NavigateToSolarFarmsv2ApiPage()
        {

            driver.Navigate().GoToUrl("https://docs.raptormaps.com/reference/apiv2solar_farms");
        }

        public void scrollToApiIntegration()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", apiIntegrationSection);
        }

        public bool URLValidator(string urlForValidation)
        {
            if (driver.Url== urlForValidation)
            {
                return true;
            }
            return false;
        }

        public  void SwitchToTab(int to = 1) => driver.SwitchTo().Window(driver.WindowHandles[to]);


    }
}
