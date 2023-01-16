using OpenQA.Selenium;
using TestTheTest.Implementation;

namespace TestTheTest.Pages
{
    public class BasePage
    {
        public IWebDriver driver;
        public ElementControl elementControl;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            elementControl = new ElementControl(driver);
            PageFactory.InitElements(driver, this);
        }
    }
}
