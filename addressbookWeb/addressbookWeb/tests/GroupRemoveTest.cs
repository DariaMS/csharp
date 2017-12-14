using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemove : BaseTest
    {

        [Test]
        public void GroupRemoveTest()
        {
            app.NavigationH.OpenHomePage();
            app.LoginH.Login(new AccountData("admin", "secret"));
            app.NavigationH.GoToGroupsPage();
            app.GroupH.SelectGroup(1);
            app.GroupH.DeleteGroup();
            app.NavigationH.GoToGroupsPage();
        } 
    }
}
