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
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        private StringBuilder verificationErrors;



        //properties

        public IWebDriver Driver
        {
            get { return driver; }
        }

        public LoginHelper LoginH
        {
            get { return loginHelper; }
        }

        public NavigationHelper NavigationH
        {
            get { return navigationHelper; }
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

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL); //initialisation
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);

        }

    
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
    }
}
