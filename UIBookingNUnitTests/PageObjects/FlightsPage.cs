using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UIBookingTests.PageObjects
{
    public class FlightsPage : Page
    {
        public FlightsPage(ChromeDriver driver) : base(driver)
        {
        }

        public override void OpenPage()
        {
            var url = "https://booking.kayak.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }
    }
}
