using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter base number:");
    int baseNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter exponent:");
    int expoNum = Convert.ToInt32(Console.ReadLine());
    int result = IntegerPower(baseNum, expoNum);
    Console.WriteLine("your result is " + result);
  }

  public static int IntegerPower(int number, int power)
  {
    int total = 1;
    for(int i = 1; i <= power; i++)
    {
      total = total * number;
    }
    return total;
  }
}