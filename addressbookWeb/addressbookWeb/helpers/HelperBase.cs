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

        private bool IsElementPresent(By by)
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
    }
}