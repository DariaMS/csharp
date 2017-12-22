using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class GroupEditTests : AuthTestBase
    {
        [Test]
        public void GroupEdit()
        {
            //prepare test data:
            GroupData newdata = new GroupData("name_edit");
            newdata.Header = "null";
            newdata.Footer = "null";

            app.GroupH.Edit(0, newdata);


        }
    }
}
