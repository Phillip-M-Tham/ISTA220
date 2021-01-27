1. A local variable is variables that exist in a method or another small section of code.

2. A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to a user. It is a programming construct that executes a command.

3. Identifiers are the names that you use to identify the elements in your programs such as namespaces, classes, methods, and variables. It can only
take in letters uppercase and lowercase, digits, and underscore characters. They must start with a letter or underscore.

4. Keywords are reserved identifiers for the use of the C# language amd cannot be reused for the coders own purpose. They are a total of 77 and each has a particular
meaning.

5. A variable is a storage location that holds a value. They must have an unambiguous name that uniquely identifies it in the context in which it is used ie: int currentAmmo = 49;

6. You declare a variable with the variable type which can be an intiger, string, boolean, char, and doubles and followed by the variable name. You assign a value to a variable with a '=' character and is
followed by the value. It should be respective of the variable type ie int is with number, strings is with characters enclosed in qoutes and boolean is true or false. You can create a variable that holds no
value initially but you will not be able to use it until you assign a value to it. You can declare and initialize a variable in the same line: int maxAmmo = 400;

7. If you open a project file without opening a solution file Visual Studio will automatically create a new solution file for it. This is problamatic because if unaware to user, the user will create multiple solutions 
for the same project.

8. Arithmatic operators and variable types are dependent on each other. You can use all of the arithmetic operators on values of
type char, int, long, float, double or decimal. You can only use the + operator on strings. Boolean does not support any operators.

9. You can turn a string to an int by using the .ToString() method, you can use string concatenation ei: string msg = "There are " + num +" cats"; Another option is use the StringBuilder with .Append() and .ToString() methods.

10. To convert an int to a string one can use the Parse(). ie: string answer = 16int.Parse(100) should return '100'

11. Precedence governs the order in which an expression's operators are evaluated. Associativity is the direction left or right in which 
the operands are evaluated. Precedence follows PEMDAS order of operations. 4/2 * 6 following precedence will evaluate to 12 but when swapping 
to right associative operators it will evaluate to 4/12.

12. Definite assignment rule is you must assign a vlaue to a variable before you can use it otherwise your program will not compile.

13. Prefix increment and decrement is seen as the variable is used after the increment or decrement has occured. If x is 42 and is used with ++x, the prefix increment is referring to the number 43.
    Postfix increment and decrement is seen as the varibale is used before the increment or decrement has occurred. If x is 42 and is used with x++, the postfix increment is refferring to the number 42.
	
14. String interpolation is a C# feature that can be used as an alternative to concatenate strings. It uses the $ symbol and the {} to state that the variable in the curly brackets
are to be subsituted in the string. This is easier on memory than using the + operator for string concatenation.

15. The keyword var can be used to infer the type of a variable from an expression and the value given. It must be assigned to a value to be initialized. They can be referred to as implicity typed variables.
	The compiler has to deduce the type of variable from the types of the expressions used to initialize them.

	
