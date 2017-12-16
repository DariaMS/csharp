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
            app.GroupH.Remove(3);
              //  .SelectGroup(1)
              //  .DeleteGroup;
        } 
    }
}
