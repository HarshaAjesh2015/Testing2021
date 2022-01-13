Feature: TMFeature
	Create,Edit, Delete data for TMPage

@mytag
Scenario: Create new Record for TM Page
	Given logged successfully into the homepage
	And I logged successfully into  the TM page
	When  details for create new record are added
	Then the result should be create new data 

	Scenario: Edit Record for TM Page
	Given logged successfully into the homepage
	And navigate successfully into the TM Page
	When data to edit the last create record are provided
	Then the result should be the edited entries

	Scenario: Delete Record for TM Page
	Given logged successfully into the homepage
	And navigate successfully into the TM Page
	When find the last created data
	Then the last created data must be deleted
