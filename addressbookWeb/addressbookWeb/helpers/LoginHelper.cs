using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
        //constructor
        public LoginHelper(AppManager manager) 
            : base(manager) {}

        public LoginHelper Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();

            return this;
        }

        public LoginHelper Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();

            return this;
        }
    }
}
