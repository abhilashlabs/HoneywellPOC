Feature: TemperatureByCity
	In order to get temperature of a city	
	I want to be told to write an api 

@mytag
Scenario: Get the temperature by city
	Given the city name as "bangalore"
	When a POST request to /api/Weather/temperatureByCity?city={city}
	Then the response StatusCode should be 200