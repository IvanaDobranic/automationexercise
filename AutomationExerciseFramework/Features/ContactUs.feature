﻿Feature: ContactUs
	As a user
	I want to be able to work with Contact Us section
	So I can message custormer support

@mytag
Scenario: User can send message via contact us form
Given user opens contact us page
When user enters all required fields
	And user submits contact us form
	And confirms the propt message
Then user will receive 'Success! Your details have been submitted successfully.' message