using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Checkout Step tWO Page on POM
    /// </summary>
    public class CheckOutStepTwoPage : BasePage
    {
        public CheckOutStepTwoPage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region locators
        private const string ID_FINISH_BUTTON = "finish";
        private const string XPATH_ITEM_TOTAL = "//div[@class='summary_subtotal_label']";
        #endregion
        #region Methods
        public void ClickFinishButton() => Driver.FindElement(By.Id(ID_FINISH_BUTTON)).Click();
        public string GetItemsTotal() => Driver.FindElement(By.XPath(XPATH_ITEM_TOTAL)).Text;
        #endregion
    }
}
