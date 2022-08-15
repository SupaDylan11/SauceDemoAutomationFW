Feature: Products

As a user, I want to to be able to find the products I am interested in, by filtering and viewing items

@HappyPath
Scenario: Inspect Product
	Given I am signed in and on the products page
	When I select the <input> I want to inspect
	Then I am taken to that "<itempage>"
Examples:
	| input | itempage                                           |
	| 1     | https://www.saucedemo.com/inventory-item.html?id=4 |
	| 2     | https://www.saucedemo.com/inventory-item.html?id=0 |

@HappyPath
Scenario: Filter Products
	Given I am signed in and on the products page
	When I select the filter dropdown
	And I select the "<filtertype>"
	Then I am displayed the "<firstitem>" as per the filter order
Examples:
	| filtertype          | firstitem |
	| Name (Z to A)       | (red)     |
	| Price (low to high) | Onesie    |

@HappyPath
Scenario: Add Item To Cart
	Given I am signed in and on the products page
	When I add an "<item>" to the cart
	Then the number of items in cart is 1
	Examples: 
	| item          |
	| fleece-jacket |
	| bike-light    |

@HappyPath
Scenario: Remove Item From Cart
	Given I am signed in and on the products page
	When I add an "<item>" to the cart
	And I remove the "<item>" from the cart
	Then the number of items in cart is 0
	Examples: 
	| item          |
	| fleece-jacket |
	| bike-light    |

@HappyPath
Scenario: Go To Basket
	Given I am signed in and on the products page
	When I press the basket button
	Then I am taken to the basket page