using System;
using System.Text;
using System.Threading;
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

        //private static AppManager instance; // static object
        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();

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
        private AppManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.UseLegacyImplementation = true;
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";

            driver = new FirefoxDriver(options); //to work with browser
            baseURL = "http://localhost";

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL); //initialisation
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        //destructor

        ~AppManager()
        {
            try
                {
                    driver.Quit();
                }
            catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                // Assert.AreEqual("", verificationErrors.ToString());
        }

        //singleton
        //method returns always just 1 object
        //Solution - threads, GetInstance will analyze 
        //if there are an instance in current thread or not
        //in this way we can run our tests parallel

        public static AppManager GetInstance()
        {
            if(! app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.NavigationH.OpenHomePage();
                app.Value = newInstance;
                //instance = new AppManager();
            }
            return app.Value;
        }
    }
}
