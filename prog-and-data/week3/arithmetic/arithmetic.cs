using System;

class arithmetic{
	static void Main( string[] args){
		string firstNumber, //First String entered by user
			   secondNumber; //Second String entered by user
		
		int number1, //first number to add
			number2; //second number to add
		
		//Prompt and read for first int
		Console.Write("Please enter your first integer: ");
		firstNumber = Console.ReadLine();
		
		//Prompt and read for second int
		Console.Write("Please enter your second integer: ");
		secondNumber = Console.ReadLine();
		
		//Convert from type string to type int
		number1 = Convert.ToInt32(firstNumber);
		number2 = Convert.ToInt32(secondNumber);
		
		//Do maths stuff
		int sum = number1 + number2;
		int difference = number1 - number2;
		int multiply = number1 * number2;
		int division = number1/number2;
		int mod = number1 % number2;
		
		Console.WriteLine("\n{0} + {1} = {2}.", number1, number2, sum); //Write sum to console
		Console.WriteLine("\n{0} - {1} = {2}.", number1, number2, difference); //Write difference to console
		Console.WriteLine("\n{0} * {1} = {2}.", number1, number2, multiply); //Write multiply to console
		Console.WriteLine("\n{0} / {1} = {2}.", number1, number2, division); //Write division to console
		Console.WriteLine("\n{0} % {1} = {2}.", number1, number2, mod); //Write mod to console
	} //Main End		
} //Arithmetic End