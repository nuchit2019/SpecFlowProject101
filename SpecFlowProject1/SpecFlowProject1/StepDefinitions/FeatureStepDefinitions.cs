using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"Open the brrowser")]
        public void GivenOpenTheBrrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [Then(@"Search for the Specflow selenium C#")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("specflow selenium C#");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);

            Thread.Sleep(555555000);
            driver.Quit();

        }

    }
}
