Feature: OrangeHRM

Test orange HRM website login functionality

Scenario: verify login for orange hrm website
	Given User is on the orange hrm login page
	When User enters the "<usrname>" and "<passwd>" in the text fields
	When user clicks on the login button
	Then user is navigated to home page

Examples: 
| usrname | passwd   |
| Admin   | admin123 | 