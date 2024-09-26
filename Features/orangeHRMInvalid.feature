Feature: orangeHRMInvalid

Test orange HRM website login functionality with invalid data

Scenario: Verify login for Orange HRM Website with Invalid Credentials
	Given User is on the Orange HRM Login Page.
	When User enters the "<usrname>" and "<passwd>" in input.
	When User clicks on Login button.
	Then User is displayed with Invalid Credentials.

Examples: 
| usrname | passwd |
| abc     | abc123 |