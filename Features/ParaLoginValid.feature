Feature: ParaLoginValid

Test parabank website login functionality valid data

Scenario: verify login for parabank website
	Given User is on Login page
	When User enters "<Username>" and "<Password>"
	And User clicks on the log in button
	Then User is navigated to Dashboard page
	
Examples: 
| Username | Password |
| sharath  | 12345    |
