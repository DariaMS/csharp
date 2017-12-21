using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        
        [Test]
        public void ContactCreation()
        {
            ContactData contact = new ContactData("Max", "Ivanov");

            app.ContactH.AddContact(contact);

        }
    }
}