Feature: Completion

As a user when I am on the completion page 
I want to go back to the product page
So that I can do more shopping

@HappyPath
Scenario: Going back to the product page for getting an confirmation
	Given I am signed in and on the confirmation page
	When I click the back home button 
	Then I am taken to product page

