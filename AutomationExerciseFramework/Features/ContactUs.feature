Feature: ContactUs
	As a user
	I want to be able to work with Contact Us section
	So I can message custormer support

@mytag
Scenario: User can send message via contact us form
Given user opens products page
		And searches for 'Winter Top' term
		And opens first search result
	When user click on Add to Cart button
		And proceeds to cart