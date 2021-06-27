using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UIBookingTests.PageObjects
{
    public class CabinetPage : Page
    {
        public CabinetPage(ChromeDriver driver) : base(driver)
        {
        }

        public override void OpenPage()
        {
            var url = "https://secure.booking.com/mydashboard.ru.html";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }
    }
}
