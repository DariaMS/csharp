using NUnit.Framework;


namespace WebAddressbookTests
{
    public class BaseTest
    {
        protected AppManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new AppManager(); //initiation
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
