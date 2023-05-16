using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    ///  Class Model of Cart Page on POM
    /// </summary>
    public class CartPage : BasePage
    {

        public CartPage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region locators 
        private const string ID_CHECKOUT_BUTTON = "checkout";
        #endregion
        #region Methods
        public void ClickCheckoutButton() => Driver.FindElement(By.Id(ID_CHECKOUT_BUTTON)).Click();
        #endregion
    }
}
