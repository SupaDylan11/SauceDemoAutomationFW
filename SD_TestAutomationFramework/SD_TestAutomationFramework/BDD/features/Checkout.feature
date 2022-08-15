Feature: Checkout

As A Logged In User
I want to checkout my basket
So that I can buy stuff


@HappyPath
Scenario: Adding valid shipping details
	Given I am signed in and on the products page
	And I click on the basket button
	And I click on the checkout button
	When I input my <firstName> in the firstname field
	And I input my <lastName> in the lastname field 
	And I input my <postalCode> in the zip code field 
	And I click the checkout button
	Then I am taken to  "<checkoutPage>"
Examples:
	| firstName | lastName | postalCode | checkoutPage                                     |
	| Bob       | Marley   | JAM 1CA    | https://www.saucedemo.com/checkout-step-two.html |
	| Tu        | Pac      | NEW Y0R3   | https://www.saucedemo.com/checkout-step-two.html |


@HappyPath
Scenario: Gives error message with invalid lastName and invalid postCode shipping details
	Given I am signed in and on the products page
	And I click on the basket button
	And I click on the checkout button
	When I input my <firstName> in the firstname field
	And I input my <lastName> in the lastname field 
	And I input my <postalCode> in the zip code field 
	And I click the checkout button
	Then I am given an Error

Examples:
	| firstName | lastName | postalCode | 
	| Bob       |		   |			| 
	| Tu        |          |			| 
