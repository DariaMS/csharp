using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        
        [Test]
        public void ContactCreation()
        {
            ContactData contact = new ContactData("Max", "Ivanov");

            app.ContactH.AddContact(contact);

        }
    }
}