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
            InitGroupEdit();
            FillGroupForm(newdata);
            SubmitGroupEdit();
            manager.NavigationH.GoToGroupsPage();

            return this;
        }

        public GroupHelper SubmitGroupEdit()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }


        public GroupHelper InitGroupEdit()
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
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;

            //extracted the method 
            //Type(By.Name("group_footer"), group.Footer);
            //from
            //driver.FindElement(By.Name("group_footer")).Clear();
            //driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);

        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            return this;
        }

        public GroupHelper DeleteGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])")).Click();
            return this;
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups = new List<GroupData>();
            manager.NavigationH.GoToGroupsPage();
            //find all elements in Groupd List (page). Tag= span, class = group
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            foreach (IWebElement element in elements)
            {
                groups.Add(new GroupData(element.Text));
            }
            return groups;
        }
    }
}
