using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIBookingTests.PageObjects
{
    public abstract class Page
    {
        protected IWebDriver driver;

        public Page(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public abstract void OpenPage();
    }
}
