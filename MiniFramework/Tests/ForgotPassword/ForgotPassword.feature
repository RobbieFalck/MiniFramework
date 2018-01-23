Feature: ForgotPassword
	In order to change my password
	As a user
	I want to click forgot password and change my password

@ForgotPassword
Scenario: Forgot Password Check
	Given I navigate to HippodromeOnline
	When I click on the forgot password link
	Then I should be taken to the forgot password page
