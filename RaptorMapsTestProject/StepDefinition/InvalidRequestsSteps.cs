using System;
using System.Threading;
using FluentAssertions;
using RaptorMapsTestProject.PageObject;
using TechTalk.SpecFlow;

namespace RaptorMapsTestProject.StepDefinition
{
    [Binding]
    public class InvalidRequestsSteps
    {
        string TokenAuth = "WyIyMDA3IiwiJDUkcm91bmRzPTUzNTAwMCQ4czdkZ0lyZkxRalN1TXlkJHZJbXJPMzFVdERYZDFlTDRZTmdDaHJwUjBhRmIydW0vampvQWYzTE1iUzYiXQ.Yk-w_w.dGRb3xdsG6TgzOTHYdhh0eSmHWk";
        string IncorrectTokenAuth = "XWyIyMDA3IiwiJDUkcm91bmRzPTUzNTAwMCQ4czdkZ0lyZkxRalN1TXlkJHZJbXJPMzFVdERYZDFlTDRZTmdDaHJwUjBhRmIydW0vampvQWYzTE1iUzYiXQ.Yk-w_w.dGRb3xdsG6TgzOTHYdhh0eSmHWk";
        RaptorMapsTechnologyPage raptorMapsTechnologyPage;

        public InvalidRequestsSteps()
        {
            raptorMapsTechnologyPage = new RaptorMapsTechnologyPage();
        }

        [Given(@"I am on the page solarfarmsv(.*) page")]
        public void GivenIAmOnThePageSolarfarmsvPage(int p0)
        {
            raptorMapsTechnologyPage.NavigateToSolarFarmsv2ApiPage();
           
        }
        
     
        [When(@"I send request with incorrect orgid")]
        public void WhenISendRequestWithIncorrectOrgid()
        {
            Thread.Sleep(2000);
            raptorMapsTechnologyPage.authenticationToken.SendKeys(TokenAuth);
            raptorMapsTechnologyPage.orgIdField.SendKeys("2");
            raptorMapsTechnologyPage.tryItButton.Click();
            Thread.Sleep(700);
        }


        [When(@"I send request with incorrect authToen")]
        public void WhenISendRequestWithIncorrectAuthToen()
        {
            Thread.Sleep(2000);
            raptorMapsTechnologyPage.authenticationToken.SendKeys(IncorrectTokenAuth);
            raptorMapsTechnologyPage.orgIdField.SendKeys("228");
            raptorMapsTechnologyPage.tryItButton.Click();
            Thread.Sleep(700);
        }


        [When(@"I send request with notfilled orgid")]
        public void WhenISendRequestWithNotfilledOrgid()
        {
            Thread.Sleep(2000);
            raptorMapsTechnologyPage.authenticationToken.SendKeys(TokenAuth);
            raptorMapsTechnologyPage.orgIdField.SendKeys("");
            raptorMapsTechnologyPage.tryItButton.Click();
            Thread.Sleep(700);
        }


        [When(@"I send request with string orgid")]
        public void WhenISendRequestWithStringOrgid()
        {
            Thread.Sleep(2000);
            raptorMapsTechnologyPage.authenticationToken.SendKeys(TokenAuth);
            raptorMapsTechnologyPage.orgIdField.SendKeys("stringg");
            raptorMapsTechnologyPage.tryItButton.Click();
            Thread.Sleep(700);
        }



        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int errorCode)
        {
            if (errorCode==403)
            {
                Thread.Sleep(2000);
                raptorMapsTechnologyPage.statusCode403.Displayed.Should().BeTrue("This verifies if 403 is displayed");
            }
            else if (errorCode==401)
            {
                Thread.Sleep(2000);

                raptorMapsTechnologyPage.statusCode401.Displayed.Should().BeTrue("This verifies if 401 is displayed");
            }
            else if (errorCode == 400)
            {
                Thread.Sleep(2000);

                raptorMapsTechnologyPage.statusCode400.Displayed.Should().BeTrue("This verifies if 400 is displayed");
            }
            else if (errorCode == 500)
            {
                Thread.Sleep(2000);

                raptorMapsTechnologyPage.statusCode500.Displayed.Should().BeTrue("This verifies if 500 is displayed");
            }

        }
    }
}
