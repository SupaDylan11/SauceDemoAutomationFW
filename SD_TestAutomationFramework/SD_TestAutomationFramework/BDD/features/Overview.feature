Feature: Overview Page

As a user when I enter valid shipping details I want to click the checkout button so I can see the conformation page

@HappyPath
Scenario: Receiving an confirmation
	Given I am signed in and on the overview page
	When I click the finish button
	Then I am taken to completePage


@HappyPath
Scenario: Going back to product page
	Given I am signed in and on the overview page
	When I click the cancel button
	Then I am taken to productpage