# Evaluator in C#
A class in C# that evaluates the result of a simple algebraic expression.


[ Functionality ]

The evaluation will ignore whitespace, but error on a non-valid character.

Valid tokens are listed in the table below:

// 0-9	:  All integers

// Symbols : (, ), +, -, *, /

( )	---- Nested expressions will be evaluated first.

+, -, *, /	--- Basic operators are addition, subtraction, multiplication and division. 
