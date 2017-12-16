using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(AppManager manager) 
            : base(manager) {}

        public GroupHelper Remove(int v)
        {
            manager.NavigationH.GoToGroupsPage();
            SelectGroup(v);
            DeleteGroup();
            manager.NavigationH.GoToGroupsPage();
            return this;
        }

        public GroupHelper Edit(int v, GroupData newdata)
        {
            manager.NavigationH.GoToGroupsPage();
            SelectGroup(v);
            //EditGroup(newdata);
            InitGroupEdit();
            FillGroupForm(newdata);
            SubmitGroupEdit();
            manager.NavigationH.GoToGroupsPage();

            return this;
        }

        private GroupHelper SubmitGroupEdit()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }


        private GroupHelper InitGroupEdit()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }


        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper Create(GroupData group)
        {
            manager.NavigationH.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            manager.NavigationH.ReturnToGroupsPage();
            return this;
    }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper DeleteGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
            return this;
        }
    }
}
