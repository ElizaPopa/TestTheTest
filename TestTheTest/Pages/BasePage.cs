using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestTheTest.Implementation;

namespace TestTheTest.Pages
{
    public class BasePage
    {
        public IWebDriver driver;
        public ElementControl elementControl;

        public BasePage(IWebDriver driver, ElementControl elementControl)
        {
            this.driver = driver;
            this.elementControl = elementControl;
            PageFactory.InitElements(driver, this);
        }
    }
}
