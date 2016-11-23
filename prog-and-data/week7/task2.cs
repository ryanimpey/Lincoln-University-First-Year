using System;
class geometry{
  //calculate the area of a circle
  public double circleArea(int radius)
  {
    return (Math.PI * (radius * radius));
  }

  //calculate the area of a circle
  public float triangleArea(float triangleBase, float triangleHeight)
  {
    return (triangleBase/2) * triangleHeight;
  }

  public float pyramidVolume(float pyramidHeight, float triangleBase, float triangleHeight)
  {
    return ((pyramidHeight * triangleBase * triangleHeight)/3f);
  }

  public static void Main(){
 //main method

  geometry MyGeometry = new geometry();

  Console.Write("Enter the radius of your circle: ");
  int radius = Convert.ToInt32(Console.ReadLine());
  double radiusTwo = MyGeometry.circleArea(radius);
  Console.WriteLine("\nThe area is {0:f3}", radiusTwo);
  //wait
  Console.WriteLine(' ');
  //wait
  Console.WriteLine("Enter the height and base of your triangle: ");
  float triangleBase = Convert.ToInt32(Console.ReadLine());
  float triangleHeight = Convert.ToInt32(Console.ReadLine());
  float triangleTotal = MyGeometry.triangleArea(triangleBase, triangleHeight);
  Console.Write("\nThe area is {0:f3}", triangleTotal);
  //wait
  Console.WriteLine(' ');
  //wait
  Console.WriteLine("Enter the height pyramid: ");
  float pyramidHeight = Convert.ToInt32(Console.ReadLine());
  float pyramidTotal = MyGeometry.pyramidVolume(pyramidHeight, triangleBase, triangleHeight);
  Console.Write("\nThe area is {0:f3}", pyramidTotal);

  }
  
}