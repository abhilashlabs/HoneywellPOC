Feature: SimpleInterest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told to calculate the simple interest 

@allcorrectvalues
Scenario: Calculates interest amount when prinicpal amount, rate and year are provided
	Given the principal amount is 1000
	And the interest rate is 2
	And the tenure is 2 
	When the calculation part is happened
	Then the simpleinterest should be 40

@withdenominatoras0
Scenario: Calculates interest amount when prinicpal amount, rate and year are provided with denominator as 0
	Given the principal amount is 1000
	And the interest rate is 2
	And the tenure is 2 
	When the calculation part is happened with denominator as 0
	Then the simpleinterest should be 0

@withwrongvalues
Scenario: Calculates interest amount when prinicpal amount, rate and year are provided but rate as -2
	Given the principal amount is 1000
	And the interest rate is -2
	And the tenure is 2 
	When the calculation part is happened with rate as -2
	Then the simple interest should be "error"