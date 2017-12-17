using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactEditTests : TestBase
    {
        [Test]
        public void ContactEditTest()
        {
            ContactData newdata = new ContactData("masha", "popova");
            app.ContactH.Edit(3, newdata);
        }


    }
}   
