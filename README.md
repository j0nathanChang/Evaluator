#  Evaluator in C# 
### https://github.com/j0nathanChang/Evaluator
A class in C# that evaluates the result of a simple algebraic expression.


## Functionality

The evaluation will ignore whitespace, but error on a non-valid character.

Valid tokens are listed in the table below:

- 0-9	:  All integers

- Symbols : (, ), +, -, *, /

*"( )" Nested expressions will be evaluated first.*

*"+ , - , \* , / " Basic operators are addition, subtraction, multiplication and division.*

## Rules

If there is/are priority in expression, a "( )" will indicate it and evaluates first.

Without a nested sign, the evaluation will start from the left to the right.

## Examples
### Terminal display :
`Input an expression: ` (User input expression)

`Result: ` (outputting result)

`(Press y/Y to exit or Press ENTER to input again.)`

*Example input expressions of the evaluator :*

|Input	             |Output Result	     |Return value|
|:-------------------|:-----------:|:----------|
| 1 + 3 |	                4|	          true|
| (1 + 3) * 2 |	          8 |        	true|
| (4 / 2) + 6	|          8	 |         true|
| 4 + (12 / (1 * 2)) |	 10	  |       true|
| (1 + (12 * 2) |	       N/A	 |       false //there is a missing bracket|
