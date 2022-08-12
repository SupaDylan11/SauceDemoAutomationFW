Feature: Products

As a user, I want to to be able to find the products I am interested in, by filtering and viewing items

@HappyPath
Scenario: Inspect Product
	Given I am signed in and on the products page
	When I select the "<item>" I want to inspect
	Then I am taken to that "<itempage>"

