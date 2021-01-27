1. A Method is a named sequence of statements. It acts as a function, it can return a value and take in parameters that is user defined.

1. Subroutines is a method that does not return a value and a function is a method that returns a value. Methods must be associated to a class.

1. The return statement returns information of a specified data type. The respective method must declare the return data type and the actual return statement is at the end of the method followed by a variable that matches the return data type. 
It can be used without following anything if the return type is void.

1. Expression-bodied methods utilize the "=>" characters to shorthand a single expression. The value of the expression is used as the return value.

1. A scope is the concept of a variable being accessed at a particular location in a program. Variables that are accessable in a method are in scope and variables that are not accessable are out of scope.

1. A field is a variable that is defined by a class. A field can be used before the statement that defines the field. 

1. Overloaded methods are two identifiers that have the same name and are declared in the same scope. It can be an accidental for most cases but intentional for methods. One can purposly overload a method to perform the same operation on different data types.

1. To call a method with arguments use the syntax as follows: result = methodname(argumentList). The argumentList is seperated by commas and the result should match the data type declared in the return data type of the method declaration.

1. To declare a method with a parameterList use the syntax as follows: returnType methodName(parameterList){
																		// method body statements go here
																		}
1. To specify an optional parameter in a method declaration use this syntax: returnType methodName(returnType mandatoryVariable, returnType optionalVariable = defualtVariableValue){
																			  //method body statements
																			  }

1. To pass an argument to a method as a named parameter one specifies the name of the parameter followed by a colon and the value you wish to use when calling the method.

1. To return values from a method using the return statement. Its return followed by variable and ;, It is possible to return multiple values by declaring a list of data types at the beginning of the method declaration process. The return statement will hold the same number of variable to pass at the return statement and the holding value that is set equal to the method will also hold the same number of variables.

1. A tuple is a small collection of values and is used for multiple values in methods. To define a method that returns multiple values use this syntax: (double,int) convertDoubleToFloatandInt(float a){
																																						   	double A = double(a);
																																							int A2 = int(a);
																																							return (A,A2);
																																						}
1. Line one declares a method called factorial that returns a long type and takes in a int called dataValue. 
	Line two is a open bracket to declare the method.
    Line three is a if statement that checks if the inserted int is equal to 1.
    Line four returns the value 1 if the int does equal 1.
    Line five is an else statement 
    Line six returns the inserted int * the declared function with the same int decremented by 1 if the int does not equal 1;	
	line seven is the closing bracket to the method.
	
1. The compiler resolves ambiguity between named arguments and optional parameters by using the method that most closely matches the method call. If the call cannot be determined to one method, the compiler does not let you compile the application.

1. COM stands for Component Object Model and is one of the principal technologies that underpins many Windows applications and services outside of the .Net framework. CLR stands for Common Language Runtime and it manages the execution of .NET programs. CLR depends converts all of the code written in different langauges to become cross compatible with .NET. CLR uses COM to accomplish this.  