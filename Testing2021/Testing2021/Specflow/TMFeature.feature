Feature: TMFeature
	As a TurnUp portal admin
	I would like to create, edit and delete time and material records
	So that I can manage my employees' time and materials successfully for TM Page

@mytag
Scenario: Create new Record for TM Page
	Given logged successfully into the homepage
	And I logged successfully into  the TM page
	When  details for create new record are added
	Then the result should be create new data

Scenario Outline: Edit Record for TM Page
	Given logged successfully into the homepage
	And navigate successfully into the TM Page
	When data to edit <Description> and <Code>are provided
	Then the result should have updated <Description> and <Code>

	Examples:
		| Description   | Code            |
		| Time          | Testing2021     |
		| Material      | edited time     |
		| Edited Record | edited material |

Scenario: Delete Record for TM Page
	Given logged successfully into the homepage
	And navigate successfully into the TM Page
	When find the last created data
	Then the last created data must be deleted