using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace UIBookingTests.PageObjects
{
    public class IndexPage : Page
    {

        private By languageButton = By.XPath("//button[@data-modal-id='language-selection']");
        private By enGbLanguageButton = By.XPath("//a[@data-lang='en-gb']");
        private By ruLanguageButton = By.XPath("//a[@data-lang='ru']");
        private By currencyButton = By.XPath("//button[@data-modal-header-async-type='currencyDesktop']");
        private By usdCurrencyButton = By.XPath("//a[contains(@data-modal-header-async-url-param, 'USD')]");
        private By bynCurrencyButton = By.XPath("//a[contains(@data-modal-header-async-url-param, 'BYN')]");
        private By locationInput = By.XPath("//input[@id='ss']");
        private By calendarButton = By.XPath("//div[@class='xp__dates-inner']");
        private By guestsButton = By.XPath("//*[@id='xp__guests__toggle']");
        private By addBabyButton = By.XPath("/html/body/div[2]/div/div/div[2]/form/div[1]/div[3]/div[2]/div/div/div[2]/div/div[2]/button[2]");
        private By yearsButton = By.XPath("//*[@id='xp__guests__inputs-container']/div/div/div[3]/select");
        private By years4Button = By.XPath("//*[@id='xp__guests__inputs-container']/div/div/div[3]/select/option[6]");
        private By searchButton = By.XPath("//*[@id='frm']/div[1]/div[4]/div[2]/button");

        public IndexPage(ChromeDriver driver) : base(driver)
        {
        }

        public override void OpenPage()
        {
            var url = "https://www.booking.com/index.ru.html";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }

        public void SelectUSDCurrency()
        {
            Thread.Sleep(1000);
            driver.FindElement(currencyButton).Click();
            Thread.Sleep(3000);
            driver.FindElement(usdCurrencyButton).Click();
            Thread.Sleep(1000);
        }

        public void SelectBYNCurrency()
        {
            Thread.Sleep(1000);
            driver.FindElement(currencyButton).Click();
            Thread.Sleep(3000);
            driver.FindElement(bynCurrencyButton).Click();
            Thread.Sleep(1000);
        }

        public void SelectEnLanguage()
        {
            Thread.Sleep(1000);
            driver.FindElement(languageButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(enGbLanguageButton).Click();
        }

        public void SelectRuLanguage()
        {
            Thread.Sleep(1000);
            driver.FindElement(languageButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(ruLanguageButton).Click();
        }

        public void Filter()
        {
            SetLocation();
            SetCalendar();
            SetGuests();

            driver.FindElement(searchButton).Click();
        }
        private void SetLocation()
        {
            driver.FindElement(locationInput).SendKeys("Минск, Минская область, Беларусь");
        }

        private void SetCalendar()
        {
            var arrivalDate = DateTime.Now.AddDays(7);
            var departureDate = DateTime.Now.AddDays(9);

            By arrivalDateButton = By.XPath($"//td[@data-date='{arrivalDate.ToString("yyyy.MM.dd").Replace('.', '-')}']");
            By departureDateButton = By.XPath($"//td[@data-date='{departureDate.ToString("yyyy-MM-dd").Replace('.', '-')}']");

            driver.FindElement(calendarButton).Click();
            Thread.Sleep(1000);

            driver.FindElement(arrivalDateButton).Click();
            driver.FindElement(departureDateButton).Click();
            Thread.Sleep(1000);
        }

        private void SetGuests()
        {
            driver.FindElement(guestsButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(addBabyButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(yearsButton).Click();
            Thread.Sleep(1000);
            driver.FindElement(years4Button).Click();
            Thread.Sleep(1000);
        }
    }
}
