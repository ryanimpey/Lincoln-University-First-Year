using System;

public class looping{

  public static void Main(string[] args){
    int widgetQuantity = 0;
    float widgetPrice = 5;
    float widgetCount = 0;

    Console.WriteLine("Please enter how many widgets you would like");
    Console.WriteLine("If you would like to pause the process, press q");
    int userInput = Convert.ToInt32(Console.ReadLine());
    do {
      while (! Console.KeyAvailable) {
        
        while (widgetQuantity <= 100){

          if(widgetQuantity > 50 && widgetQuantity <= 80){
            widgetPrice = 4f;
          } else if(widgetQuantity > 81 && widgetQuantity <= 100){
            widgetPrice = 2.5f;
          } else{
            widgetPrice = 5f;
          }

          Console.WriteLine("Widget Quantity: {0} \nWidget Price: {1:c} \n --------", widgetQuantity, widgetCount);
          widgetQuantity += 10;
          widgetCount = widgetPrice * 10;
      

      if(widgetQuantity == userInput){
        Console.WriteLine("User Maximum Reached, would you like to see more prices? \n Press Y if so ");
        string userYesNo = Console.ReadLine();
        if(userYesNo == "Y" || userYesNo == "y"){
        } else{
          break;
        }
      }
    }

      }       
    } while (Console.ReadKey(true).Key != ConsoleKey.Q);
  }
}