Feature: Test Login Functionality

feature to test the login functionality


Scenario: verify login funtionality
	Given User is on login page
	When User enters the username eand password
	And User clicks on the login button
	Then User is navigated to home page