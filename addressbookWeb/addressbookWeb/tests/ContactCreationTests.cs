using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        
        [Test]
        public void ContactCreation()
        {
            app.NavigationH.GoToContactsPage();
            app.ContactH.AddContact(new ContactData("Max","Ivanov"));

        }
    }
}
