using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestTheTest.Implementation;

namespace TestTheTest.Pages
{
    
    public class LoginPage
    {

        private IWebDriver driver;
        ElementControl elementControl;

        [FindsBy(How = How.XPath, Using = "//input[@name='username']")]
        private IWebElement UsernameInput { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement LoginButton { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            elementControl = new ElementControl(driver);
            PageFactory.InitElements(driver, this);
        }

        public void Login(string username, string password)
        {
            elementControl.SetText(UsernameInput, username);
            elementControl.SetText(PasswordInput, password);
            elementControl.ClickElement(LoginButton);
        }
    }
}
