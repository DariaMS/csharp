using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase 
    {
        [Test]
        public void LoginValid()
        {
            //preconditions
            app.LoginH.Logout();

            //action
            AccountData account = new AccountData("admin", "secret");
            app.LoginH.Login(account);

            //verification
            //Assert.IsTrue(app.LoginH.IsLoggedIn(account));
        }

        [Test]
        public void LoginNotValid()
        {
            //preconditions
            app.LoginH.Logout();

            //action
            AccountData account = new AccountData("admin", "123123");
            app.LoginH.Login(account);

            //verification
            //Assert.IsFalse(app.LoginH.IsLoggedIn(account));
        }


    }
}
