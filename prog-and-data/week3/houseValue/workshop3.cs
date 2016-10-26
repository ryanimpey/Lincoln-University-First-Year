using System;

class houseValue{
	static void Main(string[] args){
		
		Console.WriteLine("House Stamp Value Calculator");
		Console.Write("\n Please enter your property value: ");
		
		string houseValue = Console.ReadLine();
		int stampDutyRate;
		
		//Strip string of all non string values
		houseValue.Replace(",","").Replace(".","");
		
			Console.WriteLine(houseValue.GetType());
			/*
			if(houseValue > 150000 && houseValue <= 2500000 ){
				stampDutyRate = 1;
			} else if(houseValue > 250000 && houseValue <= 500000){
				stampDutyRate = 3;
			} else if(houseValue > 500000){
				stampDutyRate = 4;
			} else {
				stampDutyRate = 0;
			}
		
		float amountToPay = (houseValue/100f) * stampDutyRate;
		
		Console.WriteLine("Property Value: {0:c}", houseValue);
		Console.WriteLine("Stamp Duty rate: {0}%", stampDutyRate);
		Console.WriteLine("\nThe amount of duty to pay on this property: {0:c}", amountToPay);*/
		
	}
}