using Framework;

namespace DummyWebSiteTests
{
    [TestClass]
    public class CheckoutTests : BaseTests
    {

        [TestMethod]
        public void GivenUserExists_UserAddSomeElementsToTheCardAndCompleteTheOrder()
        {
            // Arrange
            string item1Toadd = "Sauce Labs Backpack";
            string item2Toadd = "Sauce Labs Bike Light";
            string firstName = "John";
            string lastName = "Doe";
            string zipCode = "12345";
            // Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.TypeUsername("standard_user");
            loginPage.TypePassword("secret_sauce");
            loginPage.ClickLoginButton();
            Assert.IsTrue(Driver.Url.Contains("inventory"));
            InventoryPage inventoryPage = new InventoryPage(Driver);
            inventoryPage.AddItemToCart(item1Toadd);
            string item1Price = inventoryPage.GetItemPrice(item1Toadd);
            inventoryPage.AddItemToCart(item2Toadd);
            string item2Price = inventoryPage.GetItemPrice(item2Toadd);
            string numberOfItems = inventoryPage.GetNumberOfItemsInCart();
            Assert.AreEqual(numberOfItems, "2");
            inventoryPage.ClickShoppingCartButton();
            CartPage shoppingCartPage = new CartPage(Driver);
            Assert.IsTrue(Driver.Url.Contains("cart"));
            shoppingCartPage.ClickCheckoutButton();
            CheckoutStepOnePage checkOutStepOnePage = new CheckoutStepOnePage(Driver);
            checkOutStepOnePage.TypeFirstName(firstName);
            checkOutStepOnePage.TypeLastName(lastName);
            checkOutStepOnePage.TypeZipCode(zipCode);
            checkOutStepOnePage.ClickContinueButton();
            CheckOutStepTwoPage checkOutStepTwoPage = new CheckOutStepTwoPage(Driver);
            Assert.IsTrue(Driver.Url.Contains("checkout-step-two"));
            string itemsPrice = checkOutStepTwoPage.GetItemsTotal();
            Assert.AreEqual(float.Parse(itemsPrice.Trim().Replace("Item total: $", "")), float.Parse(item1Price.Replace("$", "")) + float.Parse(item2Price.Replace("$", "")), "Item Total is not the expected");
            checkOutStepTwoPage.ClickFinishButton();
            CheckoutCompletePage checkOutCompletePage = new CheckoutCompletePage(Driver);
            Assert.AreEqual(checkOutCompletePage.GetThankYouMessage(), "Thank you for your order!", "Thank you message is not the expected");

        }
    }
}