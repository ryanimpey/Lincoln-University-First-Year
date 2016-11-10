using System;

public class looping{

  public static void Main(string[] args){
    Console.WriteLine("Please enter a string!");
    string stringInput = Console.ReadLine();
    string reversedInput = "";
    
    foreach(char c in stringInput){
      reversedInput = c + reversedInput;
    }
    Console.WriteLine("Reversed string: {0}", reversedInput);
  }
}