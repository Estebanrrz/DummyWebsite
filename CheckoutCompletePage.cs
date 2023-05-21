using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Checkout Complete Page on POM
    /// </summary>
    public class CheckoutCompletePage : BasePage
    {
        public CheckoutCompletePage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region locators
        private const string XPATH_THANK_YOU_MESSAGE = "//h2[@class='complete-header']";
        #endregion

        public string GetThankYouMessage()
        {
            return Driver.FindElement(By.XPath(XPATH_THANK_YOU_MESSAGE)).Text;
        }
    }
}
