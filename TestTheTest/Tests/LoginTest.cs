
namespace TestTheTest.Tests
{
	public class LoginTest: Base {

        string actualURL = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";


        [Test]
        public void LoginWithTheCorrectCredentials()
        {
            loginPage.Login("Admin", "admin123");
            Assert.That(driver.Url, Is.EqualTo(actualURL));
        }
    }
}

