Feature: Calculator
In order to test my application
As a developer
I want to validate different operations of the application

@smoke
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Substract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are substracted
	Then the result should be 20


Scenario: Multiply two numbers
	Given the first number is 7
	And the second number is 5
	When the two numbers are multiplied
	Then the result should be 35


Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 25
	When the two numbers are divided
	Then the result should be 2

Scenario: When the denominator is 0 for division operation
	Given the first number is 50
	And the second number is 0
	When the denomiator is 0
	Then the result should be 0