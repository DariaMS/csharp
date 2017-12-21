using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{

    [TestFixture] //attribute, NUnit framework analyziert sie
    public class GroupCreationTests : AuthTestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";

            List<GroupData> groups_old = app.GroupH.GetGroupList();

            app.GroupH.Create(group);
            List<GroupData> groups_new = app.GroupH.GetGroupList();
            Assert.AreEqual(groups_old.Count +1, groups_new.Count);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData(" ");
            group.Header = " ";
            group.Footer = " ";

            app.GroupH.Create(group);
        }
    }
}
