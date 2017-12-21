using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestClass]
    public class Theory
    {

        [TestMethod]

        public void Test()
        {
            for (int i=0; i<10; i++)
            {
                System.Console.Out.Write(i +"\n");
            }
        }

        [TestMethod]
        //array
        public void Test2()
        {
            string[] s = new string[] { "I", "want", "to", "sleep" };
            for (int i=0; i < s.Length; i++)
            {
                System.Console.Write(s[i] + "\n");
            }
        }

        [TestMethod]
        //foreach
        public void Test3()
        {
            string[] s = new string[] { "I", "want", "to", "sleep" };
            foreach(string element in s)
            {
                System.Console.Write(element + "\n");
            }
        }

        [TestMethod]
        //while
        public void Test4()
        {
            IWebDriver driver = null;
            int attempt = 0;
            while (driver.FindElement(By.Id("test")).Count == 0 && attempt < 10)
            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            }
        }
