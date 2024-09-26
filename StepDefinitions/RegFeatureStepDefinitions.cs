using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class RegFeatureStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User is on register page")]
        public void GivenUserIsOnRegisterPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.htm");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"", ""([^""]*)"", ""([^""]*)"",""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"", ""([^""]*)"" and ""(.*)")]
        public void WhenUserEntersTheAnd(string FirstName, string LastName, string Address, string City, string State, string ZipCode, string Phone, string Ssn, string Username, string Password, string ConfirmPass)
        {
            IWebElement fname = _driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            fname.SendKeys(FirstName);

            IWebElement lname = _driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            lname.SendKeys(LastName);

            IWebElement addres = _driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            addres.SendKeys(Address);

            IWebElement cit = _driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            cit.SendKeys(City);

            IWebElement stat = _driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            stat.SendKeys(State);

            IWebElement zipcode = _driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            zipcode.SendKeys(ZipCode);

            IWebElement phonenumber = _driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            phonenumber.SendKeys(Phone);

            IWebElement ssno = _driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            ssno.SendKeys(Ssn);

            IWebElement usn = _driver.FindElement(By.XPath("//input[@id='customer.username']"));
            usn.SendKeys(Username);

            IWebElement pass = _driver.FindElement(By.XPath("//input[@id='customer.password']"));
            pass.SendKeys(Password);

            IWebElement con = _driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            con.SendKeys(ConfirmPass);
            Thread.Sleep(1000);
        }

        [When(@"User clicks on the register button")]
        public void WhenUserClicksOnTheRegisterButton()
        {
            IWebElement regis = _driver.FindElement(By.XPath("//input[@value='Register']"));
            regis.Click();
            Thread.Sleep(3000);
        }

        [Then(@"User is navigated to dashboard page")]
        public void ThenUserIsNavigatedToDashboardPage()
        {
            _driver.Close();
        }
    }
}
