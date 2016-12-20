using System;
using System.IO;
class textAnalyser{

  
  //calculate the area of a circle
  public void readText()
  {
    Console.WriteLine("Please enter the text you would like to enter, ending each sentance with a *");
    string userEnteredText = Console.ReadLine();
    
    File.AppendAllText("enteredText.txt", userEnteredText);
    string readWrittenText = File.ReadAllText("enteredText.txt");
    Console.WriteLine("Would you like to enter another sentace? yes/no");
    
    string userChoice = Console.ReadLine();
    string userChoiceLowered = userChoice.ToLower();
    
    switch(userChoiceLowered){
      case "yes":
        readText();
        break;

      case "no":
        Console.WriteLine("Ok:");
        basicResponse(readWrittenText);
        break;

      default:
        Console.WriteLine("Unexpected input, taking input as a no");
        break;
    }
  }

  public string basicResponse(string writtenText){
    char[] writtenTextArray = writtenText.ToCharArray();
    foreach(char i in writtenTextArray){
      switch(i){
        case '*':
          Console.WriteLine("New sentance!");
          break;
      }
    }
    return writtenText;
  }

  //calculate the area of a circle
  public void readFile()
  {
    Console.WriteLine("Read file u cunt");
  }

  public static void Main(){
    //main method
    textAnalyser textAnalysis = new textAnalyser();

    Console.WriteLine("Welcome to TextAnalyser");
    Console.WriteLine("Would you like to enter text or read text from a file?");
    Console.WriteLine("1. Enter the text via the keyboard \n 2. Read the text from a file");

    try{
      int keyboardOrFile = Convert.ToInt32(Console.ReadLine());
      if(keyboardOrFile == 1){
        textAnalysis.readText();
      } else if(keyboardOrFile == 2){
        textAnalysis.readFile();
      } else{
        Console.WriteLine("No valid option selected. The program will now terminate.");
      }
    } catch(Exception e){
      Console.WriteLine("No valid option selected. The program will now terminate.");
    }

  }
  
}