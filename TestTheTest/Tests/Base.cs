using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestTheTest.Implementation;
using TestTheTest.Pages;
using OpenQA.Selenium.Support.UI;

namespace TestTheTest.Tests
{

    public class Base
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public ElementControl elementControl;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@name='username']")));
            loginPage = new LoginPage(driver);
            elementControl = new ElementControl(driver);
        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
