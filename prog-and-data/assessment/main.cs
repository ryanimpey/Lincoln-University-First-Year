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
    Console.WriteLine("Are you sure you have finished writing?\nIf you want to type more enter 'yes', otherwise type 'no' or hit enter to continue");
    
    string userChoice = Console.ReadLine();
    string userChoiceLowered = userChoice.ToLower();
    
    switch(userChoiceLowered){
      case "yes":
        readText();
        break;

      case "no":
        Console.WriteLine("Alright! Here is some basic information about your sentance!:");
        basicResponse(readWrittenText);
        break;

      default:
        Console.WriteLine("Taking input as a no!");
        Console.WriteLine("Here is some basic information about your sentance!:");
        basicResponse(readWrittenText);
        break;
    }
  }

  public void basicResponse(string writtenText){
    char[] writtenTextArray = writtenText.ToCharArray();
    Console.WriteLine("Number of sentances: {0}", returnSentances(writtenTextArray));
    Console.WriteLine("Number of vowels: {0}", returnVowels(writtenTextArray));
    Console.WriteLine("Number of consonants: {0}", returnCons(writtenTextArray));
    Console.WriteLine("Number of upper case letters: {0}", returnUppers(writtenTextArray));
    Console.WriteLine("Number of lower case letters: {0}", returnLowers(writtenTextArray));
    Console.WriteLine("Would you like to see the frequency of an individual letter?");
    string userChoiceLetterFrequency = Console.ReadLine().ToLower();
    switch(userChoiceLetterFrequency){
      case "yes":
        returnIndividualLetters(writtenTextArray);
        break;

      case "no":
        Console.WriteLine("Ok! The Program will now terminate!");
        break;

      default:
        Console.WriteLine("Unexpected input, taking input as a no! The Program will now terminate.");
        break;
    }
  }

  public void returnIndividualLetters(char[] enteredTextString){
  	Console.WriteLine("Please enter the letter you would like to find");

  	try{
	  	string userEnteredLetter = Console.ReadLine().ToLower();


  		int userLetterAmount = 0;

  		foreach(char i in enteredTextString){
    	  if(i.ToString().ToLower() == userEnteredLetter){
    	  	userLetterAmount++;
    	  }
    	}

    	Console.WriteLine("Found the letter {0} {1} times!", userEnteredLetter.ToUpper(), userLetterAmount);

  	} catch(Exception e){
  		Console.WriteLine("Unexpected Input! Error Code {0}", e);	
  	}

  }


  public string returnSentances(char[] enteredTextString){
  	int sentanceAmount = 0;
  	foreach(char i in enteredTextString){
      switch(i){
        case '*':
          sentanceAmount++;
          break;
        default:
          break;
      }
    }
    return sentanceAmount.ToString();
  }

  public string returnVowels(char[] enteredTextString){
  	int vowelAmount = 0;
  	foreach(char i in enteredTextString){
      if("aeiouAEIOU".Contains(i.ToString())){
      	vowelAmount++;
      }
    }
    return vowelAmount.ToString();
  }

  public string returnCons(char[] enteredTextString){
  	char[] consonantList = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w' ,'x', 'z'};
    int consonantAmount = 0;
  	foreach(char i in enteredTextString){
  		for(int j = 0; j < consonantList.Length; j++){
  			if(i == consonantList[j]){
  				consonantAmount++;
  			}
  		}
    }
    return consonantAmount.ToString();
  }

  public string returnUppers(char[] enteredTextString){
  	int upperAmount = 0;
  	foreach(char i in enteredTextString){
      if(char.IsUpper(i)){
      	upperAmount++;
      }
    }
    return upperAmount.ToString();
  }

  public string returnLowers(char[] enteredTextString){
  	int lowerAmount = 0;
  	foreach(char i in enteredTextString){
      if(char.IsLower(i)){
      	lowerAmount++;
      }
    }
    return lowerAmount.ToString();
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
    Console.WriteLine("1. Enter the text via the keyboard \n2. Read the text from a file");

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