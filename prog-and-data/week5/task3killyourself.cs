using System;

public class looping{

  class Program{
    public int Add(int x, int y){ 
      int result = x + y;
      return result;
    }
  }

  public static void Main(string[] args){
    Program prog = new Program();
    prog.Add(5,10);
  }

}