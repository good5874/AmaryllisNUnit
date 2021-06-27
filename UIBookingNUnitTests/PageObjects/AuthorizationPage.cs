using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UIBookingTests.PageObjects
{
    public class AuthorizationPage : Page
    {
        private By emailInput = By.XPath("//input[@id='username']");
        private By passInput = By.XPath("//input[@id='password']");
        private By emailSubmitButton = By.XPath("//*[@type='submit']");
        private By passSubmitButton = By.XPath("//*[@type='submit']");
        public AuthorizationPage(ChromeDriver driver) : base(driver)
        {
        }

        public override void OpenPage()
        {
            var url = "https://account.booking.com/sign-in";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }

        public void EnterEmail()
        {
            driver.FindElement(emailInput).SendKeys("q.w.e.r.t.y.u.iop@yandex.ru");
            driver.FindElement(emailSubmitButton).Click();
            Thread.Sleep(1000);
        }

        public void EnterPass()
        {
            driver.FindElement(passInput).SendKeys("qwe123QWE123");
            driver.FindElement(passSubmitButton).Click();
            Thread.Sleep(3000);
        }
    }
}
