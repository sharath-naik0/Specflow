using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParaLoginInvalidStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enter ""([^""]*)"" and ""([^""]*)""")]
        public void WhenUserEnterAnd(string Username, string Password)
        {
            IWebElement User = _driver.FindElement(By.Name("username"));
            User.SendKeys(Username);

            IWebElement Pass = _driver.FindElement(By.Name("password"));
            Pass.SendKeys(Password);
            Thread.Sleep(2000);
        }

        [When(@"User clicks on the Login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement LoginButton = _driver.FindElement(By.XPath("//input[@value='Log In']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is redirected to login page")]
        public void ThenUserIsRedirectedToLoginPage()
        {
            IWebElement Msg = _driver.FindElement(By.ClassName("title"));

            string txt = Msg.Text;

            Assert.AreEqual("Error!", txt);
            _driver.Close();

            Thread.Sleep(2000);
        }
    }
}
