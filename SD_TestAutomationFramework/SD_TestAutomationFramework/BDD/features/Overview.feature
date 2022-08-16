Feature: Overview

As a user when I enter valid shipping details I want to click the checkout button so I can see the conformation page

@HappyPath
Scenario: Receiving an confirmation
	Given I am signed in and on the products page
	And I click on the basket button
	And I click on the checkout button
	And I enter "Bob" in the first-name box
	And I enter "Marley" in the last-name box
	And I enter "JAM 1CA" in the postal-code box
	And I click on the continue button in  the checkout page
	When I click the finish button in the overview page
	Then I am taken to completePage


@HappyPath
Scenario: Going back to product page
	Given I am signed in and on the products page
	And I click on the basket button
	And I click on the checkout button
	And I enter "Bob" in the first-name box
	And I enter "Marley" in the last-name box
	And I enter "JAM 1CA" in the postal-code box
	And I click on the continue button in  the checkout page
	When I click the cancel button in the overview page
	Then I am taken to productpage