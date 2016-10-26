using System;

public class TaskFour{

  public static void Main(string[] args){

    Console.WriteLine("Please enter a value 0 - 100:");
    int gradeRating = Convert.ToInt32(Console.ReadLine());

    if(gradeRating >= 0 && gradeRating <= 39){
      Console.WriteLine("Score {0}: Fail", gradeRating);
    } else if (gradeRating >= 40 && gradeRating <= 49){
      Console.WriteLine("Score {0}: Third Class (Grade D)", gradeRating);
    } else if (gradeRating >= 50 && gradeRating <= 59){
      Console.WriteLine("Score {0}: Lower Second (Grade C)", gradeRating);
    } else if (gradeRating >= 60 && gradeRating <= 69){
      Console.WriteLine("Score {0}: Upper Second (Grade B)", gradeRating);
    } else if (gradeRating >= 70 && gradeRating <= 100){
      Console.WriteLine("Score {0}: First Class (Grade A)", gradeRating);
    } else {
      Console.WriteLine("Not a valid score: {0} is not between 0 and 100", gradeRating);
    }
  }

}