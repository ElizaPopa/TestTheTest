using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestTheTest.Implementation;
using TestTheTest.Pages;

namespace TestTheTest.Tests
{

    public class Base
    {
        IWebDriver driver;
        public LoginPage loginPage;
        public ElementControl elementControl;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            //Thread.Sleep(5000);
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
