using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : BaseTest
    {
        
        [Test]
        public void ContactCreation()
        {
            app.NavigationH.OpenHomePage();
            app.LoginH.Login(new AccountData("admin", "secret"));
            app.ContactH.AddContact(new ContactData("Max","Ivanov"));
            // ERROR: Caught exception [Error: Dom locators are not implemented yet!]
            app.LoginH.LogOut();
        }
    }
}
