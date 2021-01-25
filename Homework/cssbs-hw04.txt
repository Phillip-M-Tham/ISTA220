1. Boolean expressions can hold only true and false as a a value.

1. Equality operators are == and !=, which is respectively is equal to and is not equal to. 
Relational operators are <,<=,>,>= and are used to determine if one value is less than or greater than another value of the same data type.
Logical operators are &&, || and NOT they respectively represent AND and OR. These operators are all similar by all are utilized in predicate 
expressions. They are all different because they each are used for separate functionality in the expression.

1. Short circuiting is when a long boolean expression is determined in the earlier portion of the expression making the rest of the
conditions to check not applicable.

1. For short circuiting in regards to &&, is when the left portion of the && is determined to make the expression fail the predicate logic.
  For short circuiting in regards to || is when the left portion of the of || is determined to make the expression succeed the predicate logic.
  It is useful to design the simpler expression on the left and the complex expressions on the right of the operator to improve efficeincy of 
  your code.
  
1. The Operators with the highest precedence are the primary category operators which include (),++ and --. The operators with the lowest precedence
   are in the Assignment category which is comprised of =.
   
1. Curly braces make blocks of code, the computer recognizes that the statements enclosed in the blocks are associated with the respective conditional
if else statemnts. 

1. Omitting the keyword break in a switch statement is a bad practice and can lead to bugs. Without a break statement, an exception can fall into the next
label and break the switch case by inteded design.

1. Switch keyword declares a switch case and is followed by parenthesis that contains the controlling expression.
   The keyword case is used to match the controlling expression contained in the switch () with a pre determined answer, if it does match the code that follows
   the : character, the enclosed code is ran.
   The keyword break is used to end the code running and break out of the switch cases. Removing or omitting it will let the switch statement check cases when 
   it is necessarily already finished in finding a matching case.
   The keyword defualt is used to determine what happens in the switch statement if none of the cases actually match the controlling expression contained in the 
   switch statement.
   
1. The big difference between recurr1 and recurr2 is that recurr2 requires a second parameter named product. They both are set for factorial calculation but recurr2 uses the first parameter to create
   tail recursion. 

1. A recursive method is a method that calls itself. 
	Private static int AddNums(int []a, int length){
		if (length == 0)
			return 0;
		else
			return AddNums(a, length-1) + a[length -1]
	}

1. Not (snowing OR raining) is the same as NOT (snowing AND raining). If it is not snowing or raining than it is also not snowing and raining.
   I'm (not running or not walking) is the same as Not (running and walking). If i'm not running or not walking than I am not running and walking.
   answer != Snowing || Raining == answer != Snowing && Raining. 
   
   
   