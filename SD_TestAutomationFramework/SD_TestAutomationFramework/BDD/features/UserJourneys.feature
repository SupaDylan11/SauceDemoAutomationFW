Feature: UserJourneys

A short summary of the feature

@SuccessfulShop
Scenario: User gives £££ to (Sauce) Demo website
	Given I am logged in and on the products page
	When I add <Product1> and <Product2> to the cart and go to my basket
	And remove the second product <Product2> and click the Checkout button
	And I input my details <FirstName> <LastName> and <PostCode> for the checkout 
	And I click Finish button
	Then I am taken to the complete page
Examples:
| Product1   | Product2      | FirstName | LastName      | PostCode |
| bike-light | bolt-t-shirt  | Prince    | Rogers Nelson | 34018	|  
