using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using UIBookingTests.PageObjects;

namespace UIBookingNUnitTests
{
    [SingleThreaded]
    public class BookingTests
    {
        private IndexPage indexPage;
        private FlightsPage flightsPage;
        private AuthorizationPage  authorizationPage;
        private CabinetPage  cabinetPage;
        private ChromeDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            indexPage = new IndexPage(driver);
            flightsPage = new FlightsPage(driver);
            authorizationPage = new AuthorizationPage(driver);
            cabinetPage = new CabinetPage(driver);
        }

        [Test]
        public void ChangeCurrency()
        {
            indexPage.OpenPage();
            indexPage.SelectUSDCurrency();
            indexPage.SelectBYNCurrency();
        }

        [Test]
        public void ChangeLanguage()
        {
            indexPage.OpenPage();
            indexPage.SelectEnLanguage();
            indexPage.SelectRuLanguage();
        }

        [Test]
        public void OpenFlights()
        {
            flightsPage.OpenPage();
        }

        [Test]
        public void CheckFilter()
        {
            indexPage.OpenPage();
            indexPage.Filter();
        }

        [Test]
        public void Authorization()
        {
            authorizationPage.OpenPage();
            authorizationPage.EnterEmail();
            authorizationPage.EnterPass();
            cabinetPage.OpenPage();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}