using NUnit.Framework;
using System.Collections.Generic;
using System.Threading;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemove : AuthTestBase
    {

        [Test]
        public void GroupRemoveTest()
        {
            List<GroupData> groups_old = app.GroupH.GetGroupList();

            app.GroupH.Remove(0);
            
            List<GroupData> groups_new = app.GroupH.GetGroupList();

            //delete the 1st element in group
            groups_old.RemoveAt(0);
            Assert.AreEqual(groups_old, groups_new);

        } 
    }
}
