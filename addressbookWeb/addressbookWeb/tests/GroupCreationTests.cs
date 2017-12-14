using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture] //attribute, NUnit framework analyziert sie
    public class GroupCreationTests : BaseTest
    {

        [Test]
        public void GroupCreationTest()
        {
            app.NavigationH.OpenHomePage();
            app.LoginH.Login(new AccountData("admin", "secret"));
            app.NavigationH.GoToGroupsPage();
            app.GroupH.InitGroupCreation();

            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            app.GroupH.FillGroupForm(group);

            app.GroupH.SubmitGroupCreation();
            app.NavigationH.ReturnToGroupsPage();
            app.LoginH.LogOut();
        }
    }
}
