using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactEditTests : AuthTestBase
    {
        [Test]
        public void ContactEditTest()
        {
            ContactData newdata = new ContactData("sasha", "karlov");
            app.ContactH.Edit(3, newdata);
        }


    }
}   
