Feature: RestaurantCheckoutSystem

A short summary of the feature

@tag1
Scenario: singleOrder
	Given A group of 4 people orders 4 starters, 4 mains and 4 drinks
	When the order is sent to the endpoint
	Then the total is calculated correctly in the bill

Scenario: multipleOrder
	Given A group of 2 people order 1 starter and 2 mains and 2 drinks before 19 
	When the order is sent to the endpoint
	Then the total is calculated correctly in the bill	
	When 2 more people at 20 who order 2 mains and 2 drinks
	And the updated order is sent to the endpoint
	Then the total is calculated correctly in the bill.

