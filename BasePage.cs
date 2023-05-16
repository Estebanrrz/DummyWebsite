using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework
{
    /// <summary>
    /// Base Page Class
    /// </summary>
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// Find Element with explicit Wait
        /// </summary>
        /// <param name="byMethod"></param>
        /// <returns></returns>
        public IWebElement FindElement(By byMethod)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(byMethod));
        }
    }
}
