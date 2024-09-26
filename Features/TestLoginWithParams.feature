@Sanity
Feature: TestLoginWithParams

Test login with test data parameters

Background: 
	Given User is on login page

@Regression
Scenario: verify login funtionality	
	When User enters the username eand password
	And User clicks on the login button
	Then User is navigated to home page


Scenario Outline: Verify login with test parameters	
	When User enters the "<username>" and "<password>"
	And User clicks on the login button
	Then User is navigated to home page
	Then User selected city and country information
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |

Examples: 
| username | password |
| tom      | Harry    |
| jerry    | Mathew   |
