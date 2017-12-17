using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactDeleteTests : TestBase
    {

        [Test]
        public void ContactDeleteEditFormTest()
        {
            app.ContactH.DeleteEditForm(3);
        }

        [Test]
        public void ContactDeleteTest()
        {
            app.ContactH.Delete(2);
        }
    }
}
