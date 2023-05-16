using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Core
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(WebBrowser name)
        {
            switch (name)
            {
                case WebBrowser.Firefox:
                    return new FirefoxDriver();
                case WebBrowser.Chrome:
                default:
                    return new ChromeDriver();
            }
        }
    }
}
