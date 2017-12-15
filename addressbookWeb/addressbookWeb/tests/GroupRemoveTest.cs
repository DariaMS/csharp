using NUnit.Framework;
using System.Threading;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemove : TestBase
    {

        [Test]
        public void GroupRemoveTest()
        {
            app.GroupH.SelectGroup(3);
            app.GroupH.DeleteGroup();
              //  .SelectGroup(1)
              //  .DeleteGroup;
        } 
    }
}
