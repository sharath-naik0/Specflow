using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaLoginValidStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on Login page")]
        public void GivenUserIsOnLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEntersAnd(string Username, string Password)
        {

            IWebElement User = _driver.FindElement(By.Name("username"));
            User.SendKeys(Username);

            IWebElement Pass = _driver.FindElement(By.Name("password"));
            Pass.SendKeys(Password);
            Thread.Sleep(2000);
        }

        [When(@"User clicks on the log in button")]
        public void WhenUserClicksOnTheLogInButton()
        {
            IWebElement LoginButton = _driver.FindElement(By.XPath("//input[@value='Log In']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is navigated to Dashboard page")]
        public void ThenUserIsNavigatedToDashboardPage()
        {
            IWebElement find = _driver.FindElement(By.XPath("//a[normalize-space()='Find Transactions']"));

            find.Click();

            _driver.Close();

            Thread.Sleep(2000);
        }
    }
}
