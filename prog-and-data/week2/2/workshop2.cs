using System;

class types{
	static void Main(string[] args){
		Console.WriteLine("Hi!");
		
		Console.WriteLine("Please enter a String value, such as your name");
		string myString = Console.ReadLine();
		
		Console.WriteLine("Ok, now an integer. Such as your age");
		int myInteger = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("And lastly, enter a double! Such as 3.14159265359");
		double myDouble = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("\nVariable 1: {0} Value: {1}", nameof(myString), myString);
		Console.WriteLine("Variable 2: {0} Value: {1}", nameof(myInteger), myInteger);
		Console.WriteLine("Variable 3: {0} Value: {1}", nameof(myDouble), myDouble);
	}
}