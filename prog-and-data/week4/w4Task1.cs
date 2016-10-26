using System;

public class TaskFour{

  public static void Main(string[] args){

    Console.Write("Enter a whole number:");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if(userNumber % 2 == 0){
      Console.WriteLine("Your number is even!");
    } else {
      Console.WriteLine("Your number is odd!");
    }
    Console.WriteLine("--------------------");
  }

}