Feature: Completion

As a user when I am on the completion page 
I want to go back to the product page
So that I can do more shopping

@HappyPath
Scenario: Going back to the product page for getting an confirmation
	Given I am signed in and on the products page
	And I click on the basket button
	And I click on the checkout button
	And I enter "Bob" in the first-name box
	And I enter "Marley" in the last-name box
	And I enter "JAM 1CA" in the postal-code box
	And I click on the continue button in the checkout page
	And I click on the finish button in the overview page
	When I click the back home button 
	Then I am taken to product page

