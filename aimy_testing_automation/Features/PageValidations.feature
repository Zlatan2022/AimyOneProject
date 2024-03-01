Feature: PageValidations

As a tester, I want to validate the content of various AimyOne Portal pages so that I can ensure proper rendering, 
correct data display, and functionality.

@tag1
Scenario: [1Verify user lands on dashboard after login]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	Then [I should see the dashboard page]

Scenario: [2Validate Accounts under Customers]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	And [I click on the Customers submenu]
	And [I select Accounts from the dropdown menu]
	Then [I should be redirected to the /customer/account page]

Scenario: [3Validate Attendees under Customers]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	And [I click on the Customers submenu]
	And [I select Attendees from the dropdown menu]
	Then [I should be redirected to the /customer/attendees page]

Scenario: [4Validate Booking Manager under Booking]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	And [I click on the Booking submenu]
	And [I select Booking Manager from the dropdown menu]
	Then [I should be redirected to the /booking/manager]

Scenario: [5Validate Booking under Booking]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	And [I click on the Booking submenu]
	And [I select Booking from the dropdown menu]
	Then [I should be redirected to the /booking/class]

Scenario: [6Validate Booking Reconciliation under Booking]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	And [I click on the Booking submenu]
	And [I select Booking Reconciliation from the dropdown menu]
	Then [I should be redirected to the /booking/reconciliation]

Scenario: [7Validate Booking Reconciliation under Booking]
	When [When I enter "12341234" as the password and "ivica.cuncic@gmail.com" as the username and click login]
	And [I click on the Booking submenu]
	And [I select Waiting List from the dropdown menu]
	Then [I should be redirected to the /booking/waiting-list]


