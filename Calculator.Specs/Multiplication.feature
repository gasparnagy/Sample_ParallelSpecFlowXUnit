Feature: Multiplication

@mytag
Scenario Outline: Add two numbers
	Given I have entered <a> into the calculator
	And I have entered <b> into the calculator
	When I press multiply
	Then the result should be <result> on the screen

Examples: 
	| case          | a  | b  | result |
	| classic       | 50 | 70 | 3500   |
	| commutativity | 70 | 50 | 3500   |
	| zero          | 0  | 42 | 0      |
	| one           | 1  | 42 | 42     |
