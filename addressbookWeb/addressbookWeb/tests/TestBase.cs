﻿using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {
        protected AppManager app;

        [SetUp]
        public void SetupAppManager()
        {
            //app = new AppManager(); //initiation
            app = AppManager.GetInstance();
            //app.NavigationH.OpenHomePage();
            //app.LoginH.Login(new AccountData("admin", "secret"));
            //moved to TestSuiteFixture

            //app.LoginH.Logout();
        }
    }
}
