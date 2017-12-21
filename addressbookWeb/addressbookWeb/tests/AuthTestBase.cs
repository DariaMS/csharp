using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class AuthTestBase : TestBase
    {
        [SetUp]
        public void SetupLogin()
        {
            //app = new AppManager(); //initiation
            app.LoginH.Login(new AccountData("admin", "secret"));
            //app.NavigationH.OpenHomePage();
            //app.LoginH.Login(new AccountData("admin", "secret"));
            //moved to TestSuiteFixture

            //app.LoginH.Logout();
        }

    }
}
