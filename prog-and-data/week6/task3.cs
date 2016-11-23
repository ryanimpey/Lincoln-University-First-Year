using System;

public class looping{

  public static void Main(string[] args){
    Console.WriteLine("Please enter a string:");
    string userInput = Console.ReadLine();
    char[] array = userInput.ToCharArray();
    Array.Reverse(array);

    foreach(char spaghetti in array){
      if(spaghetti == ' '){  
      }
      else{
        Console.Write("  {0}", spaghetti);
      }
    }
  }
}