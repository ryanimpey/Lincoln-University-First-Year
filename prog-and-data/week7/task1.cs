using System;
class geometry{
  public static void Main(){
 //main method

  Console.Write("Enter the radius of your circle: ");
  int radius = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("\nThe area is {0:f3}", circleArea(radius));
  //wait
  Console.WriteLine(' ');
  Console.WriteLine("Enter the height and base of your triangle: ");
  float triangleBase = Convert.ToInt32(Console.ReadLine());
  float triangleHeight = Convert.ToInt32(Console.ReadLine());
  Console.Write("\nThe area is {0:f3}", triangleArea(triangleBase, triangleHeight));

  }
  
  //calculate the area of a circle
  public static double circleArea(int radius)
  {
    return (Math.PI * (radius * radius));
  }

  //calculate the area of a circle
  public static float triangleArea(float triangleBase, float triangleHeight)
  {
    return (triangleBase/2) * triangleHeight;
  }
}