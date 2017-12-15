using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        public string baseURL;

        public NavigationHelper(AppManager manager, string baseURL) 
            : base(manager)
        { this.baseURL = baseURL; }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

    }
}
