using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    public class AppManager
    {
        protected IWebDriver driver;
        protected string baseURL;


        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        private StringBuilder verificationErrors;



        //properties
        public LoginHelper LoginH
        {
            get { return loginHelper; }
        }

        public NavigationHelper NavigationH
        {
            get { return navigator; }
        }

        public GroupHelper GroupH
        {
            get { return groupHelper; }
        }

        public ContactHelper ContactH
        {
            get { return contactHelper; }
        }

        //constructor 
        public AppManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";

            driver = new FirefoxDriver(options); //to work with browser
            baseURL = "http://localhost/";

            loginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL); //initialisation
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);

        }

        //methods
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
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
