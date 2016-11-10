using System;

public class looping{

  public static void Main(string[] args){
    Console.WriteLine("Please enter a string!");
    string stringInput = Console.ReadLine();
    
    Console.WriteLine("Please enter a number!");
    int numInput = Convert.ToInt32(Console.ReadLine());

    Console.Write("Entered Values:");
    Console.WriteLine("{0}, {1}", stringInput, numInput);

    int stringLength = Convert.ToInt32(stringInput.Length);
    if(stringLength < numInput){

      /*int difference = numInput - stringLength;
      string dots = "";
      //For statement looping over
      for(var i = 0; i < difference; i++){
        dots = "." + dots;
      }*/
      Console.WriteLine("meme");
    }
    Console.WriteLine("String cut down: {0}", stringInput.Substring(0, numInput));
  }
}