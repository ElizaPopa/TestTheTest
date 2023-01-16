using OpenQA.Selenium;

namespace TestTheTest.Tests
{
	public class LoginTest : Base {

        [Test]
        public void LoginWithCorrectCredentials()
        {
        
        loginPage.LoginWithCredentials("Admin", "admin123");
            //string actualURL = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
            //string expectedURL = 
            //Assert.Equals(actualURL, expectedURL);
            //Assert.Pass
        }
    }
}

