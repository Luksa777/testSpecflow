using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using RaptorMapsTestProject.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace RaptorMapsTestProject.StepDefinition
{
    [Binding]
    public class RaptorMapsNavSteps
    {
        RaptorMapsTechnologyPage raptorMapsTechnologyPage;
        
        string TokenAuth = "WyIyMDA3IiwiJDUkcm91bmRzPTUzNTAwMCQ4czdkZ0lyZkxRalN1TXlkJHZJbXJPMzFVdERYZDFlTDRZTmdDaHJwUjBhRmIydW0vampvQWYzTE1iUzYiXQ.Yk-w_w.dGRb3xdsG6TgzOTHYdhh0eSmHWk";
        public RaptorMapsNavSteps()
        {
            raptorMapsTechnologyPage = new RaptorMapsTechnologyPage();
        }


        [Given(@"I navigate to the RaptorMaps jobs page")]
        public void GivenINavigateToTheRaptorMapsJobsPage()
        {
            raptorMapsTechnologyPage.NavigateToRaptorMaps();
        }

        [Given(@"I click on the “Technology” dropdown")]
        public void GivenIClickOnTheTechnologyDropdown()
        {
            raptorMapsTechnologyPage.technologyButton.Click();
        }


        [Then(@"I should be on the RaptorMaps Technology page")]
        public void ThenIShouldBeOnTheRaptorMapsTechnologyPage()
        {
            raptorMapsTechnologyPage.URLValidator("https://raptormaps.com/rmtechnology/")
                .Should()
                .BeTrue("To validate if I am on correct url");
            raptorMapsTechnologyPage.technologyButton.Displayed.Should().BeTrue("Because this verifies if text-content is shown");

        }
       
        [Given(@"I scroll down to API integration section")]
        public void GivenIScrollDownToAPIIntegrationSection()
        {
            raptorMapsTechnologyPage.scrollToApiIntegration();
        }

        [Given(@"I validate section content")]
        public void GivenIValidateSectionContent()
        {
            raptorMapsTechnologyPage.apiIntegrationSectionTitle.Displayed.Should().BeTrue("Verifies if API Integration title is shown");
            raptorMapsTechnologyPage.apiIntegrationSectionText
                .Text
                .Should()
                .Contain("Raptor Maps easily integrates software solutions through our API. Clients can use the API to push or pull data between tools, maximizing the value of both tools while increasing data output and analysis. ");

            raptorMapsTechnologyPage.apiIntegrationSectionPhoto.Displayed.Should().BeTrue("Verifies if Photo is displayed");
            raptorMapsTechnologyPage.KnowledgeHubButton.Displayed.Should().BeTrue("Verifies if KnowledgeButton Is Enabled is displayed");
            raptorMapsTechnologyPage.KnowledgeHubButton.Text.Should().Be("KNOWLEDGE HUB");
            raptorMapsTechnologyPage.KnowledgeHubButton.Click();
            raptorMapsTechnologyPage.SwitchToTab();
            raptorMapsTechnologyPage.URLValidator("https://docs.raptormaps.com/reference/reference-getting-started#reference-getting-started")
                .Should().BeTrue("Because this verifies if KnowledgeHub Button is redirecting on correct page"); 
        }

        [Given(@"I select api/v(.*)/solar_farms page from Solar Farms Endpoints")]
        public void GivenISelectApiVSolar_FarmsPageFromSolarFarmsEndpoints(int p0)
        {
            raptorMapsTechnologyPage.solfarFarmEndpoint.Click();
            Thread.Sleep(1000);
            raptorMapsTechnologyPage.apiV2SolarFarm.Click();
            Thread.Sleep(1000);


        }

        [Given(@"I Validate form contents")]
        public void GivenIValidateFormContents()
        {
            raptorMapsTechnologyPage.yourRequestHistoy.Displayed.Should().BeTrue("Validates form contents");
            raptorMapsTechnologyPage.queryParams.Displayed.Should().BeTrue("Validates form contents");
            raptorMapsTechnologyPage.Responses.Displayed.Should().BeTrue("Validates form contents");
            raptorMapsTechnologyPage.WarningText1.Text.Should().Contain("https://docs.raptormaps.com/v3.0/reference#search_solar_farms_by_name");
            raptorMapsTechnologyPage.WarningText1.Text.Should().Contain("Endpoint to retrieve all solar farms that you have access to view in a particular organization");
        }


        [Given(@"I input parameters into fields")]
        public void GivenIInputParametersIntoFields()
        {
            raptorMapsTechnologyPage.authenticationToken.SendKeys(TokenAuth);
            raptorMapsTechnologyPage.orgIdField.SendKeys("228");
        }

        [Given(@"I press try it button")]
        public void GivenIPressTryItButton()
        {
            raptorMapsTechnologyPage.tryItButton.Click();
        }


        [Then(@"I validate status code")]
        public void ThenIValidateStatusCode()
        {
            raptorMapsTechnologyPage.statusCode200.Displayed.Should().BeTrue("This verifies if 200 ok is displayed");
        }

    }
}
