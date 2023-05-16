using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Checkout Step One Page on POM
    /// </summary>
    public class CheckoutStepOnePage : BasePage
    {

        public CheckoutStepOnePage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region locators
        private const string ID_FIRST_NAME = "first-name";
        private const string ID_LAST_NAME = "last-name";
        private const string ID_ZIP_CODE = "postal-code";
        private const string ID_CONTINUE_BUTTON = "continue";
        #endregion
        #region Methods
        public void TypeFirstName(string firstName) => Driver.FindElement(By.Id(ID_FIRST_NAME)).SendKeys(firstName);
        public void TypeLastName(string lastName) => Driver.FindElement(By.Id(ID_LAST_NAME)).SendKeys(lastName);
        public void TypeZipCode(string zipCode) => Driver.FindElement(By.Id(ID_ZIP_CODE)).SendKeys(zipCode);
        public void ClickContinueButton() => Driver.FindElement(By.Id(ID_CONTINUE_BUTTON)).Click();

        #endregion
    }
}
