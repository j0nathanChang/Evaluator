# [ Evaluator in C# ]
A class in C# that evaluates the result of a simple algebraic expression.


# Functionality

The evaluation will ignore whitespace, but error on a non-valid character.

Valid tokens are listed in the table below:

// 0-9	:  All integers

// Symbols : (, ), +, -, *, /

( )	---- Nested expressions will be evaluated first.

+, -, *, /	--- Basic operators are addition, subtraction, multiplication and division. 

# Rules

If there is/are priodrity in expressions, a "( )" will indicate it and evaluate first.

Without a Nested sign, the evaluation will start from the left to the right.

# Examples

Example input expressions of the evaluator should be able to parse:
Input	             Result	     Return code
1 + 3	                4	          true
(1 + 3) * 2	          8         	true
(4 / 2) + 6	          8	          true
4 + (12 / (1 * 2))	 10	          true
(1 + (12 * 2)	       N/A	        false (missing bracket)
