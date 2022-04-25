Feature: RaptorMapsNav
	In order to navigate through the RaptorMaps web pages
	I will need to test the functionality of the action buttons

@mytag
Scenario: Navigate to tech page
	Given I navigate to the RaptorMaps jobs page
	And I click on the “Technology” dropdown
	And I scroll down to API integration section
	And I validate section content
	And I select api/v2/solar_farms page from Solar Farms Endpoints 
	And I Validate form contents
	And I input parameters into fields
	And I press try it button
	Then I validate status code 
	#Then I should be on the RaptorMaps Technology page