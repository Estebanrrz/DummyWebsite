using Framework.Core;
using OpenQA.Selenium;

namespace Framework
{
    /// <summary>
    /// Class Model of Inventory Page on POM
    /// </summary>
    public class InventoryPage : BasePage
    {
        public InventoryPage(SeleniumWebDriver driver) : base(driver)
        {
        }
        #region locators
        private const string XPATH_ITEM_BY_NAME_PARTIAL = "//div[@class='inventory_item_name'][contains(text(),'{0}')]/ancestor::div[@class='inventory_item']";
        private const string XPATH_ADD_TO_CART_BUTTON = ".//button[contains(@class,'btn_inventory')]";
        private const string XPATH_SHOPPING_CART_BUTTON = "//a[contains(@class,'shopping_cart_link')]";
        private const string XPATH_COUNT_SHOPPING_CART = "//div[@id='shopping_cart_container']/a/span";
        private const string XPATH_ITEM_PRICE = ".//div[@class='inventory_item_price']";
        #endregion
        #region Methods
        public void ClickShoppingCartButton() => Driver.FindElement(By.XPath(XPATH_SHOPPING_CART_BUTTON)).Click();
        public string GetNumberOfItemsOnShoppingCart() => Driver.FindElement(By.XPath(XPATH_COUNT_SHOPPING_CART)).Text;
       
        /// <summary>
       /// Add Item to Cart by Item Name
       /// </summary>
       /// <param name="itemName">Item to add to the cart</param>
        public void AddItemToCart(string itemName)
        {
            var item = Driver.FindElement(By.XPath(string.Format(XPATH_ITEM_BY_NAME_PARTIAL, itemName)));
            item.FindElement(By.XPath(XPATH_ADD_TO_CART_BUTTON)).Click();
        }

        /// <summary>
        /// Get Item Price by Item Name
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public string GetItemPrice(string itemName)
        {
            var item = Driver.FindElement(By.XPath(string.Format(XPATH_ITEM_BY_NAME_PARTIAL, itemName)));
            return item.FindElement(By.XPath(XPATH_ITEM_PRICE)).Text;
        }

        /// <summary>
        /// Get Number of items added to the cart 
        /// </summary>
        /// <returns></returns>
        public string GetNumberOfItemsInCart()
        {
        return Driver.FindElement(By.XPath(XPATH_COUNT_SHOPPING_CART)).Text;
        }
        #endregion
    }
}
