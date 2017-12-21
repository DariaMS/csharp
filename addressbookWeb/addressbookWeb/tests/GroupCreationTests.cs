using NUnit.Framework;

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

            app.GroupH.Create(group);
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
