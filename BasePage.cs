using Framework.Core;


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
