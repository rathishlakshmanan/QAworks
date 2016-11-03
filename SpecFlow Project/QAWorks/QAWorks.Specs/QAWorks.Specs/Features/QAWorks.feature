Feature: Contact Us Page
	As an end user
	I want a contact us page
	So that I can find more about QAWorks exciting services!!

@mytag
Scenario: Valid Submission
	Given I am on the QAWorks Site
	Then I should be able to contact QAWorks with the following information
	| fields  | values									  |
	| name    | j.Bloggs                                  |
	| email   | j.Bloggs@qaworks.com                      |
	| message | Please contact me I want to find out more |


	