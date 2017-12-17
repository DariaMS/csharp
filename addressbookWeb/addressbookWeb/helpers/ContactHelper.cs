using System;
using OpenQA.Selenium;


namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(AppManager manager) 
            : base(manager) {}


        public ContactHelper AddContact(ContactData contact)
        {
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            manager.NavigationH.GoToAddContactsPage();
            return this;
        }

        public ContactHelper Delete(int v)
        {
            SelectContact(v);
            DeleteClickContact();
            return this;
        }

        //Delete Contact via EditForm
        public ContactHelper DeleteEditForm(int v)
        {
            SelectEditContact(v);
            //InitContactEdit();
            DeleteClickContact();
            return this;
        }

        public ContactHelper DeleteClickContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper Edit(int v, ContactData newdata)
        {
            SelectEditContact(v);
           // InitContactEdit();
            FillContactForm(newdata);
            SubmitContactEdit();
            return this;
        }

        public ContactHelper SubmitContactEdit()
        {

            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper SelectEditContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])["+ index +"]")).Click();
            //driver.FindElement(By.XPath("(//input[@name='selected[]'][@id=8])")).Click();
            driver.FindElement(By.XPath(".//*[@title='Edit']")).Click();
            return this;
        }


        /*
        public ContactHelper InitContactEdit()
        {
           
            driver.FindElement(By.XPath(".//*[@title='Edit']")).Click();
            return this;

        }
        */

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public ContactHelper NavigateAddContact()
        {
            manager.NavigationH.GoToAddContactsPage();
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            //driver.FindElement(By.Name("photo")).Clear();
            //driver.FindElement(By.Name("photo")).SendKeys("C:\\Users\\daria\\Desktop\\screenshot_2.png");
            //driver.FindElement(By.Name("company")).Clear();
            //driver.FindElement(By.Name("company")).SendKeys("Google");
            //driver.FindElement(By.Name("address")).Clear();
            //driver.FindElement(By.Name("address")).SendKeys("Moskva");
            //driver.FindElement(By.Name("email")).Clear();
            //driver.FindElement(By.Name("email")).SendKeys("max.ivanov@example.com");
            //new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            //new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            //driver.FindElement(By.Name("byear")).Clear();
            //driver.FindElement(By.Name("byear")).SendKeys("2000");
            return this;
        }

        private ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
    }
}
