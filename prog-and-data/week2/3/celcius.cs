using System;

class celcius{
	static void Main(string[] args){
		Console.WriteLine("Celcius to Fahrenheit converter.\n");
		
		Console.WriteLine("Please enter a temperature in Celcius");
		float celciusInput = float.Parse(Console.ReadLine());
		float initialDivision = 9/5f;
		float valueInF = initialDivision*celciusInput+32f;
	  Console.WriteLine("Your celcius temperature in Fahrenheit is {0}!", valueInF);
	}
}