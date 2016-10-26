using System;

public class TaskFour{

  public static void Main(string[] args){

    Console.WriteLine("Temperature Converter");
    Console.WriteLine("Please choose your conversion type");
    Console.WriteLine("[1] Fahrenheit to Celcius \n [2] Celcius to Fahrenheit");
    int userDecision = Convert.ToInt32(Console.ReadLine());
    switch(userDecision){
      case 1:
        //F to C
        Console.WriteLine("Please enter a temperature in Fahrenheit");
        float fahrenheitInput = float.Parse(Console.ReadLine());
        float valueInC = ((fahrenheitInput-32)*5)/9f;
        Console.WriteLine("Your celcius temperature in Celcius is {0}!", valueInC);
        break;
      case 2:
        //C to F
        Console.WriteLine("Please enter a temperature in Celcius");
        float celciusInput = float.Parse(Console.ReadLine());
        float initialDivision = 9/5f;
        float valueInF = initialDivision*celciusInput+32f;
        Console.WriteLine("Your celcius temperature in Fahrenheit is {0}!", valueInF);
        break;
      default:
        Console.WriteLine("No valid option selected. The program will now terminate.");
        break;
    }
  }

}