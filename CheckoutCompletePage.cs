using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Checkout Complete Page on POM
    /// </summary>
    public class CheckoutCompletePage : BasePage
    {
        public CheckoutCompletePage(IWebDriver driver) : base(driver)
        {
        }
        #region locators
        private const string XPATH_THANK_YOU_MESSAGE = "//h2[@class='complete-header']";
        #endregion
    }
}
