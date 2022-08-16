Feature: Signin

A short summary of the feature

@HappyPath
Scenario: User Login
	Given I have entered user credentials
	When I click the sign in button
	Then I will be taken to the main store page

@SadPath1
Scenario: Locked User Login
	Given I have entered locked out user credentials
	When I click the sign in button
	Then I will have a locked out error

@SadPath2
Scenario: Invalid User Login
	Given I have entered invalid credentials
	When I click the sign in button
	Then I will have an error

