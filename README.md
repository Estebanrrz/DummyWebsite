# DummyWebsite
The expected outcome is an automated test framework for the https://www.saucedemo.com/ dummy website. Use the standard_user whose credentials are provided on the main page. Automate the purchase flow.

## Manual Test Case: GivenUserExists_UserAddSomeElementsToTheCardAndCompleteTheOrder()

### Test Case ID: TC001
Test Case Title: User adds items to the cart and completes the order
### Preconditions:
User is registered
### Test Steps:
Enter the valid username "standard_user".

Enter the valid password "secret_sauce".

Click on the Login button.

Verify that the user is redirected to the inventory page.

Add the item "Sauce Labs Backpack" to the cart.

Get the price of the "Sauce Labs Backpack" item.

Add the item "Sauce Labs Bike Light" to the cart.

Get the price of the "Sauce Labs Bike Light" item.

Verify that the number of items in the cart is "2".

Click on the Shopping Cart button.

Verify that the user is redirected to the cart page.

Click on the Checkout button.

Enter the first name as "John".
Enter the last name as "Doe".

Enter the zip code as "12345".

Click on the Continue button.

Verify that the user is redirected to the checkout step two page.

Get the total price of the items displayed on the checkout step two page.

Verify that the calculated total price of the items matches the sum of the individual item prices.

Click on the Finish button.

Verify that the user is redirected to the checkout complete page.

Verify that the "Thank you for your order!" message is displayed.

### Expected Results:
The user should be able to add items to the cart and complete the order successfully.

The total price of the items should be calculated correctly.

The "Thank you for your order!" message should be displayed on the checkout complete page.


## Test Data:
Username: standard_user
Password: secret_sauce
Item 1: Sauce Labs Backpack
Item 2: Sauce Labs Bike Light
First Name: John
Last Name: Doe
Zip Code: 12345
