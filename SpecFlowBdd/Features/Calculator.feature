﻿Feature: Calculator
In order to test my application
As a developer
I want to validate different operations of the application
 
@add
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120


