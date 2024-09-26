using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestLoginFunctionalityStepDefinitions
    {
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            Console.WriteLine("Test User is on login page");
        }

        [When(@"User enters the username eand password")]
        public void WhenUserEntersTheUsernameEandPassword()
        {
            Console.WriteLine("Test User enters the username eand password");
        }

        [When(@"User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            Console.WriteLine("Test User clicks on the login button");
        }

        [Then(@"User is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            Console.WriteLine("Test User is navigated to home page");
        }
    }
}
