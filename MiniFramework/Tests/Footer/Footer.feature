Feature: ForgotPassword
	In order check players have a direct access to blackjack page
	As a QA/PO
	I want to verify that the new Blackjack link is available in the hippodrome footer

@Footer
Scenario: Find Blackjack Footer Link
	Given I navigate to HippodromeOnline
	When I login
	And I close modal pop up
	And I scroll down to the footer links
	Then I should be able to view the blackjack link