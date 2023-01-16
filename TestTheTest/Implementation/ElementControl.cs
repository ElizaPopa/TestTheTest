using OpenQA.Selenium;

namespace TestTheTest.Implementation
{
    public class ElementControl
    {
        IWebDriver driver;
        public ElementControl(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickElement(IWebElement element)
        {
            element.Click();
        }
        public void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
        public void AcceptAlert()
        {
            IAlert simpleAlert = driver.SwitchTo().Alert();
        }
    }
}
