using Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Framework
{
    /// <summary>
    /// Base Page Class
    /// </summary>
    public abstract class BasePage
    {
        protected SeleniumWebDriver Driver;
        public BasePage(SeleniumWebDriver driver)
        {
            Driver = driver;
        }

            }
}
