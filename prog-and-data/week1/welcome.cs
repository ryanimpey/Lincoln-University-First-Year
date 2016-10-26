//welcome.cs
//Text-printing application

using System;

public class Welcome{
	
	//~~ Main method begins execution of C# application~~
	public static void Main( string[] args ){
			
			DateTime dateAndTime = DateTime.Now;
			
			//Writes to the console
			Console.WriteLine("Unit: CMP1127M \"Programming and Data Structures\"");
			Console.Write("Today\'s date is ");
			//Not wrapped in "" as it is not a string we are printing.
			Console.Write(dateAndTime.ToString("dd/MM/yyyy"));
			//Read all written lines above and print to console.
			Console.ReadLine();
			
	}
	// ~~End of method Main~~
}