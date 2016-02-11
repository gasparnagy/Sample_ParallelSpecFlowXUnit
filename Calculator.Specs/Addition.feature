Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add two numbers
	Given I have entered <a> into the calculator
	And I have entered <b> into the calculator
	When I press add
	Then the result should be <result> on the screen

Examples: 
	| case          | a  | b  | result |
	| classic       | 50 | 70 | 120    |
	| commutativity | 70 | 50 | 120    |
	| zero          | 0  | 42 | 42     |
