Feature: Login

The feature allows users to log in to the application using their username and password.




@tag1
Scenario: [1Invalid Credentials - Empty Password]
	When [When I enter "" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	Then [I should see an error message indicating that the password is required]

Scenario: [2Invalid Credentials - Empty Username]
	When [When I enter "password" as the password and "" as the username and click login]
	Then [I should see an error message indicating that the username is required]

Scenario: [5Valid Credentials]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	Then [I should see the dashboard page]

Scenario: [3Invalid Credentials - Non-existent Username]
	When [When I enter "12341234" as the password and "invalid_username" as the username and click login]
	Then [I should see an error message indicating Invalid username or password]

Scenario: [4Invalid Credentials - InvalidPassword]
	When [When I enter "123" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	Then [I should see an error message indicating Invalid username or password]


