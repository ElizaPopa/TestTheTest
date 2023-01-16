using OpenQA.Selenium;


namespace TestTheTest.Pages
{
    
    public class LoginPage : BasePage
    {
        IWebElement usernameInput = driver.FindElement(By.XPath("//input[@name='username']"));
        IWebElement passwordInput = driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));

        public LoginPage(IWebDriver driver) { base(driver); }

        public void LoginWithCredentials(string username, string password)
        {
            elementControl.SetText(usernameInput, username);
            elementControl.SetText(passwordInput, password);
            elementControl.ClickElement(loginButton);
        }
    }
}
