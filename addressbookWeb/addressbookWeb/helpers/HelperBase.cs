using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected AppManager manager;
        protected IWebDriver driver;


        public HelperBase(AppManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //edit not empty fields
        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }

        //extracted the method 
        //Type(By.Name("group_footer"), group.Footer);
        //from
        //driver.FindElement(By.Name("group_footer")).Clear();
        //driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);

    }
}