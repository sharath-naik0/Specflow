using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class OrangeHRMStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public IWebDriver _driver;

        public OrangeHRMStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }

        [Given(@"User is on the orange hrm login page")]
        public void GivenUserIsOnTheOrangeHrmLoginPage()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters the ""([^""]*)"" and ""([^""]*)"" in the text fields")]
        public void WhenUserEntersTheAndInTheTextFields(string usrname, string passwd)
        {
            IWebElement Username = _driver.FindElement(By.Name("username"));
            Username.SendKeys(usrname);

            IWebElement Password = _driver.FindElement(By.Name("password"));
            Password.SendKeys(passwd);
            Thread.Sleep(2000);
        }

        [When(@"user clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            IWebElement LoginButton = _driver.FindElement(By.XPath("//button[@type='submit']"));
            LoginButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            IWebElement Admin = _driver.FindElement(By.XPath("(//a[@class = 'oxd-main-menu-item'])[1]"));

            Admin.Click();

            _driver.Close();

            Thread.Sleep(2000);
        }
    }
}
