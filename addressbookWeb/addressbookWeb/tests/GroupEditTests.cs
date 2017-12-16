using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]

    public class GroupEditTests : TestBase
    {
        [Test]
        public void GroupEdit()
        {
            //prepare test data:
            GroupData newdata = new GroupData("name_2");
            newdata.Header = "header_2";
            newdata.Footer = "footer_2";

            app.GroupH.Edit(1, newdata);


        }
    }
}
