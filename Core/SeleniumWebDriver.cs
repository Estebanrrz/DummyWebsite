using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework.Core
{
    /// <summary>
    /// implemented IDriver interface  for SeleniumWebDriver
    /// </summary>
    public class SeleniumWebDriver : IDriver
    {
        public IWebDriver wrappedDriver { get; }
        public string Url { get => wrappedDriver.Url; set => wrappedDriver.Navigate().GoToUrl(value); }


        public SeleniumWebDriver(string Type)
        {
            Enum.TryParse(Type, out WebBrowser type);
            wrappedDriver = WebDriverFactory.CreateWebDriver(type);
        }
        public void Quit()
        {
            wrappedDriver?.Quit();
        }

        /// <summary>
        ///  Creates new  IOptions based on the IwebElement
        /// </summary>
        /// <returns></returns>
        public IOptions Manage()
        {
            return wrappedDriver.Manage();
        }

        /// <summary>
        ///  Creates new  INavigation based on the IwebElement
        /// </summary>
        /// <returns></returns>
        public INavigation Navigate()
        {
            return wrappedDriver.Navigate();
        }

        /// <summary>
        /// creates new  IWebelement based on the IwebElement
        /// </summary>
        /// <param name="by"></param>
        /// <returns></returns>
        public IWebElement FindElement(By by)
        {
            WebDriverWait wait = new WebDriverWait((IWebDriver)wrappedDriver, TimeSpan.FromSeconds(10));
            return wait.Until(ExpectedConditions.ElementExists(by));
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
