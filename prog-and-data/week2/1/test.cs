using System;

class types{
	//Main method
	static void Main(string[] args){
		int myInt = 10;
		
		//Output: myInt = 10;
		Console.WriteLine("myInt = {0}", myInt);
		
		//Now change myInt = 55;
		myInt = 10+ 45;
		Console.WriteLine("myInt = {0}", myInt);
		
		float myFloat = 1.234f;
		Console.WriteLine("myFloat = {0}", myFloat);
		
		decimal myDecimal = 28.24m;
		Console.WriteLine("myDecimal = {0}", myDecimal);
		
		Console.WriteLine("please enter a value");
		decimal cashValue = Convert.ToDecimal(Console.ReadLine());
		Console.WriteLine("The cash value you entered is {0:c}", cashValue);
	}
}