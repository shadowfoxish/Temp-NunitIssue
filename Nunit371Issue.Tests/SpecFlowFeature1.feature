Feature: TwoTimesTables
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@maths
Scenario Outline: Multiply two numbers
	Given I have a mathy instance
	When I multiply the numbers '<lhs>' and '<rhs>'
	Then The result is valid '<calculated>'

	Examples:
| lhs | rhs | calculated |
| 2   | 1   | 2          |
| 2   | 5   | 10         |