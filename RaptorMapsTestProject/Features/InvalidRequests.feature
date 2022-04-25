Feature: InvalidRequests
	Checking various invalid requests via API

@mytag
Scenario: Input wrong orgid
	Given I am on the page solarfarmsv2 page
	When I send request with incorrect orgid
	Then the result should be 403


@mytag
Scenario: Input wrong Authtoken
	Given I am on the page solarfarmsv2 page
	When I send request with incorrect authToen
	Then the result should be 401

@myag
Scenario: Input empty orgid
	Given I am on the page solarfarmsv2 page
	When I send request with notfilled orgid
	Then the result should be 400


@myag
Scenario: Input string in orgid
	Given I am on the page solarfarmsv2 page
	When I send request with string orgid
	Then the result should be 500