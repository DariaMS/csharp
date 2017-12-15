using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
        protected AppManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new AppManager(); //initiation
            app.NavigationH.OpenHomePage();
            app.LoginH.Login(new AccountData("admin", "secret"));
            app.LoginH.Logout();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
