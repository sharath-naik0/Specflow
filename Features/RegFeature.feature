Feature: RegFeature

feature to test registration with test data parameters

Scenario Outline: Registration with test data parameters	
	Given User is on register page
	When User enters the "<FirstName>", "<LastName>", "<Address>","<City>", "<State>", "<ZipCode>", "<Phone>", "<Ssn>", "<Username>", "<Password>" and "<ConfirmPass>
	And User clicks on the register button
	Then User is navigated to dashboard page
	
Examples: 
| FirstName | LastName | Address | City      | State     | ZipCode | Phone    | Ssn | Username | Password | ConfirmPass |
| sharat    | naik     | abc     | mangalore | karnataka | 581262  | 56587859 | 111 | sharath  | 12345    | 12345       |
| abcd      | efgh     | ijk     | bangalore | kerala    | 456789  | 0778965  | 222 | abcd     | 1234     | 1234        |
