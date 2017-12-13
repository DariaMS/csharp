using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture] //attribute, NUnit framework analyziert sie
    public class GroupCreationTests : BaseTest
    {

        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();

            GroupData group = new GroupData("aaa");
            group.Header = "bbb";
            group.Footer = "ccc";
            FillGroupForm(group);

            SubmitGroupCreation();
            ReturnToGroupsPage();
            LogOut();
        }
    }
}
