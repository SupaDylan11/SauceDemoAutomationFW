Feature: Products

As a user, I want to to be able to find the products I am interested in, by filtering and viewing items

@HappyPath
Scenario: Inspect Product
	Given I am signed in and on the products page
	When I select the <input> I want to inspect
	Then I am taken to that "<itempage>"
	Examples:
	| input | itempage                                             |
	| 1     | https://www.saucedemo.com/inventory-item.html?id=4 |
	| 2     | https://www.saucedemo.com/inventory-item.html?id=0   |
