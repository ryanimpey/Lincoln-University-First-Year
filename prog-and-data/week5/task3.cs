using System;

public class looping{

  class Program{
    public bool repeatFunction(){ 
      float widgetPrice = 0;

      Console.WriteLine("Please enter the amount of widgets you would like 0-100:");
      int userInput = Convert.ToInt32(Console.ReadLine());
      bool repeatIt = true;

      while(repeatIt == true){
        if(userInput <= 50){
          widgetPrice = 5f * userInput;
          Console.WriteLine("{0} Widgets will cost you: {1:c}", userInput, widgetPrice);
        }
        if(userInput > 50 && userInput <= 80){
          widgetPrice = 4f * userInput;
          Console.WriteLine("{0} Widgets will cost you: {1:c}", userInput, widgetPrice);
        }
        if(userInput > 80){
          widgetPrice = 2.5f * userInput;
          Console.WriteLine("{0} Widgets will cost you: {1:c}", userInput, widgetPrice);
        }
        repeatIt = false;
      }

      askUser();
      return true;
    }

    public bool askUser(){
      Console.WriteLine("Would you like to see the price of another widget amount?");
      Console.WriteLine("Press Y to continue or Q to Quit");
      string doesUserRepeat = Console.ReadLine();

      if(doesUserRepeat == "Y" || doesUserRepeat == "y"){
        repeatFunction();
        return true;
      }
      else{
        return false;
      }
    }
  }

  public static void Main(string[] args){

    int widgetQuantity = 0;
    float widgetPrice = 0;

    Console.WriteLine("Price of Widgets:");

    while(widgetQuantity < 101){
      if(widgetQuantity <= 50){
        widgetPrice = widgetQuantity*5;
      }
      if(widgetQuantity > 50 && widgetQuantity <= 80){
        widgetPrice = widgetQuantity*4;
      }
      if(widgetQuantity > 80){
        widgetPrice = widgetQuantity*2.5f;
      }
      Console.WriteLine("Quantity: {0}", widgetQuantity);
      Console.WriteLine("Price: {0:c}", widgetPrice);
      widgetQuantity += 10;
    }

    Program prog = new Program();
    prog.repeatFunction();
  }
}