Feature: ParaLoginInvalid

Test parabank website login functionality invalid data

Scenario: verify login for parabank website invlid data
	Given User is on Login Page
	When User enter "<Username>" and "<Password>"
	And User clicks on the Login button
	Then User is redirected to login page
	
Examples: 
| Username | Password |
| qwerty   | 12345    |