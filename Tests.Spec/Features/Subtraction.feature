Feature: Subtraction
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the difference between two numbers

Scenario Outline: Subtract two numbers
	Given the first number is <num1>
	And the second number is <num2>
	When the two numbers are subtracted
	Then the result should be <result>
	Examples: 
		| num1 | num2 | result |
		| 50   | 70   | -20    |
		| 100  | 80   | 20     |