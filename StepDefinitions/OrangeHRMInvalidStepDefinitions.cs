using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMInvalidStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on the Orange HRM Login Page\.")]
        public void GivenUserIsOnTheOrangeHRMLoginPage_()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in input\.")]
        public void WhenUserEntersTheAndInInput_(string usrname, string passwd)
        {
            IWebElement Username = _driver.FindElement(By.Name("username"));
            Username.SendKeys(usrname);

            IWebElement Password = _driver.FindElement(By.Name("password"));
            Password.SendKeys(passwd);
            Thread.Sleep(2000);
        }

        [When(@"User clicks on Login button\.")]
        public void WhenUserClicksOnLoginButton_()
        {
            IWebElement LoginButton = _driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"User is displayed with Invalid Credentials\.")]
        public void ThenUserIsDisplayedWithInvalidCredentials_()
        {
            IWebElement Msg = _driver.FindElement(By.XPath("//p[contains(normalize-space(),'Invalid credentials')]"));

            string txt = Msg.Text;

            Assert.AreEqual("Invalid credentials", txt);
            _driver.Close();

            Thread.Sleep(2000);
        }
    }
}
