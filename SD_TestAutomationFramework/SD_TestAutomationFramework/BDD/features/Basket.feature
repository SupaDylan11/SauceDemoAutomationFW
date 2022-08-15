 Feature: Basket

Functionality to do with baskets. Adding and removing items to baskets. 
Checking that this is reflected in the count / number of items

@HappyPath
Scenario: Remove An Item from Baskets Page
	Given I am signed in and on the products page
	And I add an <Item> to the basket
    When I go to the Basket page
	And click the Remove <Item> button
	Then the <Item> should be removed
Examples:
| Item   |
| fleece-jacket |
| backpack |
