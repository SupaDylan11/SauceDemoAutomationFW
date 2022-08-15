Feature: UserJourneys

A short summary of the feature

@SuccessfulShop
Scenario: User gives £££ to (Sauce) Demo website
	Given I am logged in and on the products page
	When I add a <Product> to the cart and go to my basket
	And input my details for the checkout
	Then I am taken to the complete page
Examples:
| Product   |
| onesie |