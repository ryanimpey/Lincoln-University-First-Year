using System;
using System.IO;
class textAnalyser{

  
  //Read Text function which allows the user to enter text
  public void readText()
  {
  	//Asks user to enter any text they would like to enter then saves it in a string called userEnteredText
    Console.WriteLine("Please enter the text you would like to enter, ending each sentance with a *");
    string userEnteredText = Console.ReadLine();
    

    //Appends this text to the enteredText file which is created. Then reads the text from the file, ensuring we have the correct text.
    File.AppendAllText("enteredText.txt", userEnteredText);
    string readWrittenText = File.ReadAllText("enteredText.txt");

    //Asks user to confirm they finished typing and didn't make a misclick
    Console.WriteLine("Are you sure you have finished writing?\nIf you want to type more enter 'yes', otherwise type 'no' or hit enter to continue");
    
    //Saves the user response as a string and transfers it to the switch statement
    string userChoice = Console.ReadLine();
    string userChoiceLowered = userChoice.ToLower();
    
    //User response switch statement to check if they would like to continue writing or progess. 
    switch(userChoiceLowered){
      //If yes, re-run the readText() function. 
      case "yes":
        readText();
        break;

      //If no, give the user some information about the text, more detailed documentation in basicResponse() function
      case "no":
        Console.WriteLine("Alright! Here is some basic information about your sentance!:");
        basicResponse(readWrittenText);
        break;

      //If user did not enter yes or no take the input as a no and continue to basicResponse()
      default:
        Console.WriteLine("Taking input as a no!");
        Console.WriteLine("Here is some basic information about your sentance!:");
        basicResponse(readWrittenText);
        break;
    }
  }

  public void basicResponse(string writtenText){
  	//Text user entered is parsed through as writtenText and converted to a char array for statements
    char[] writtenTextArray = writtenText.ToCharArray();

    /*  The following writeline commands get a string returned from the function defined, each calling its own function.
    More detailed documentation in individual functions */

    Console.WriteLine("Number of sentances: {0}", returnSentances(writtenTextArray));
    Console.WriteLine("Number of vowels: {0}", returnVowels(writtenTextArray));
    Console.WriteLine("Number of consonants: {0}", returnCons(writtenTextArray));
    Console.WriteLine("Number of upper case letters: {0}", returnUppers(writtenTextArray));
    Console.WriteLine("Number of lower case letters: {0}", returnLowers(writtenTextArray));

    //Ask the user if they would like to see how often a certain letter appears in the text
    Console.WriteLine("Would you like to see the frequency of an individual letter?");
    string userChoiceLetterFrequency = Console.ReadLine().ToLower();
    switch(userChoiceLetterFrequency){

      //If yes, take them to the returnIndividualLetters() function
      case "yes":
        returnIndividualLetters(writtenTextArray);
        break;

      case "no":
        //If no, terminate the program and run the deleteTextFile function to delete the text file created earlier.
        Console.WriteLine("Ok! The Program will now terminate!");
        deleteTextFile();
        break;

      default:
        //If neither option is selected, take input as a no and terminate the program, then run the deleteTextFile function to delete the text file created earlier.
        Console.WriteLine("Unexpected input, taking input as a no! The Program will now terminate.");
        deleteTextFile();
        break;
    }
  }


  //Get the amount of individual letters in the text as asked by the user.
  public void returnIndividualLetters(char[] enteredTextString){
  	Console.WriteLine("Please enter the letter you would like to find");

  	//Try to get the user entered letter.
  	try{
	  	string userEnteredLetter = Console.ReadLine().ToLower();


  		int userLetterAmount = 0;

  		//If successful then run a foreach which will get every character in the text and see how many letters are the same as the one the user asked to find

  		foreach(char i in enteredTextString){
    	  if(i.ToString().ToLower() == userEnteredLetter){
    	  	//Increment the letter count
    	  	userLetterAmount++;
    	  }
    	}


    	//Response with the found amount of letters with the userLetterAmount converted to string
    	Console.WriteLine("Found the letter {0} {1} times!", userEnteredLetter.ToUpper(), userLetterAmount);
    	deleteTextFile();
  	} catch(Exception e){
  		Console.WriteLine("Unexpected Input! Error Code {0}", e);
  		deleteTextFile();
  	}

  }

  //Return the amount of sentances in the text, as show by *'s
  public string returnSentances(char[] enteredTextString){
  	int sentanceAmount = 0;

  	//Check every character in the text
  	foreach(char i in enteredTextString){
      switch(i){
        case '*':
          //If it is a * then increment the sentanceAmount count
          sentanceAmount++;
          break;
        default:
          break;
      }
    }
    if(sentanceAmount == 0){
    	sentanceAmount++;
    }
    //Return the sentanceAmount in string form for Console to Write
    return sentanceAmount.ToString();
  }

  //Return the amount of vowels in the text
  public string returnVowels(char[] enteredTextString){
  	int vowelAmount = 0;

  	//Check every character in the string
  	foreach(char i in enteredTextString){
  	  //Basic checking method. If the char i is found in the string "aeiouAEIOU" then increment the vowelAmount count
      if("aeiouAEIOU".Contains(i.ToString())){
      	vowelAmount++;
      }
    }
    //Return the vowelAmount in string form for Console to Write
    return vowelAmount.ToString();
  }

  //Return the amount of consonants in the text
  public string returnCons(char[] enteredTextString){
  	char[] consonantList = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z', 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w' ,'x', 'y', 'z'};
    int consonantAmount = 0;
    //For loop inside a foreach loop to check char.
  	foreach(char i in enteredTextString){
  		//For every single character in the enteredTextString run a for loop for the consonant list
  		//This will get the character defined as 'i' and go through every item in the consonant list and see if it is a match.
  		for(int j = 0; j < consonantList.Length; j++){
  			//If it is a match, increment the consonant amount by one.
  			if(i == consonantList[j]){
  				consonantAmount++;
  			}
  		}
    }
    //Return the consonantAmount in string form for Console to Write
    return consonantAmount.ToString();
  }

  //Return the amount of upper case letters in the text
  public string returnUppers(char[] enteredTextString){
  	int upperAmount = 0;

  	//For every charcter in the string
  	foreach(char i in enteredTextString){
  	  //Use inbuilt function to see if the char is an upperCase letter
      if(char.IsUpper(i)){
      	//If it is, increment upperAmount
      	upperAmount++;
      }
    }
    //Return the upperAmount in string form for Console to Write
    return upperAmount.ToString();
  }

  //Does the same as the returnUppers function but for lower case instead
  public string returnLowers(char[] enteredTextString){
  	int lowerAmount = 0;

  	//Check every char and see if it is a lower case letter. This could've also been done using the !char.IsUpper(i) function but for simplicity I have used the inbuilt function.
  	foreach(char i in enteredTextString){
      if(char.IsLower(i)){
      	lowerAmount++;
      }
    }
    return lowerAmount.ToString();
  }

  //For entering text from a file. Find the amount of long words in a text file (defined as greater than 7 chars in length)
  public string returnLongWords(string enteredTextString){
  	//Creates a string array called enteredTextConvert 
  	string[] enteredTextConvert;

  	//Splits the string into a string array at every space (' ')
  	enteredTextConvert = enteredTextString.Split(' ');

  	//define longWordAmount as 0
  	int longWordAmount = 0;

  	//For every characted in the convertedString
  	foreach(string i in enteredTextConvert){
  	  //If the length of the string in the array is > 7 increment the long word amount
      if(i.Length > 7){
      	longWordAmount++;
      	//Also add it to the longWords file, followed by a newline for easy reading.
      	File.AppendAllText("longWords.txt", i + Environment.NewLine);
      }
    }

    //Return the longWordAmount in string form for Console to write
    return longWordAmount.ToString();
  }

  //Read file function if user selects to enter text from a file
  public void readFile()
  {
  	//Ask the user to enter their file directory in string form
    Console.WriteLine("Ok! Please enter the full path of the file you wish to read.\nPlease make sure it is a .txt file as well!\n(If you enter the phrase 'default' then a default file will open");
    Console.Write("Text File path: ");
    string userFilePath = Console.ReadLine();
    switch(userFilePath){
    	//If user enters "default" then run the default program.
    	case "default":
    		//Default.txt is the file from blackboard detailing Yahoo's abuse-detecting algorithm
    		string defaultFilePath = "default.txt";
    		//Read the file using defaultFilePath as the directory string
    		string[] defaultFileRead = File.ReadAllLines(defaultFilePath);
    		//Needs converting to a string for processing so do this with string.Join
    		string defaultFileString = string.Join("", defaultFileRead);
    		//Run the returnLongWords function
    		Console.WriteLine("Found {0} word(s) with a length greater than 7!", returnLongWords(defaultFileString)); 
    		//Run the basicResponse function
    		basicResponse(defaultFileString);
    		break;
    	//Default switch statement run (Could've used a better variable string check for 'default it seems').
    	default:
    		try{

    			//Do the same as above in the "Default" case by reading the file into a string array
    			//Read the file using defaultFilePath as the directory string
    			string[] userFileRead = File.ReadAllLines(userFilePath);
    			//Needs converting to a string for processing so do this with string.Join
    			string userFileString = string.Join("", userFileRead);
    			//Run the returnLongWords function
    			Console.WriteLine("Found {0} words with a length greater than 7!", returnLongWords(userFileString)); 
    			//Run the basicResponse function
    			basicResponse(userFileString);

    		} catch(Exception e){
    			//If the program encounters an error finding the URL let the user try again by reporting the error
    			Console.WriteLine("\nEncountered an error trying to read file, are you sure you have specified the correct file/directory?\n Returning you to previous input");
    			//Then returning them to the readFile() function
    			readFile();
    		}
    		break;
    }
  }

  //deleteTextFile function
  public void deleteTextFile(){
  	//Delete the text file made earlier when the user asked to enter text manually
  	File.Delete("enteredText.txt");
  }

  //Run on startup
  public static void Main(){
    //Create a new object so that main can find functions and run methods
    textAnalyser textAnalysis = new textAnalyser();

    //Write basic introduction to console.
    Console.WriteLine("Welcome to TextAnalyser");
    Console.WriteLine("Would you like to enter text or read text from a file?");
    Console.WriteLine("1. Enter the text via the keyboard \n2. Read the text from a file");


    //Check if the user entered 1 or 2
    try{
      int keyboardOrFile = Convert.ToInt32(Console.ReadLine());
      if(keyboardOrFile == 1){
      	//If 1 was entered run the readText function
        textAnalysis.readText();
      } else if(keyboardOrFile == 2){
      	//If 2 was entered run the readFile function
        textAnalysis.readFile();
      } else{
      	//If neither 1 or two is entered then terminate the program
        Console.WriteLine("No valid option selected. The program will now terminate.");
      }
    } catch(Exception e){
      //Makes sure that program doesn't crash if an integer was entered.
      //Alerts user that their input was invalid and now the program will exit
      Console.WriteLine("No valid option selected. The program will now terminate.");
    }

  }
  
}