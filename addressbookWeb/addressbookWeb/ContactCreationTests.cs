﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : BaseTest
    {
        
        [Test]
        public void ContactCreation()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            AddContact(new ContactData("Max","Ivanov"));
            // ERROR: Caught exception [Error: Dom locators are not implemented yet!]
            LogOut();
        }
    }
}
