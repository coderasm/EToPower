using System;

namespace PowerOfE
{
  class Program
  {
    static void Main(string[] args)
    {
      var eToOne = Math.Round(MathExtended.eToPow(1), 5);
      var eToThree = Math.Round(MathExtended.eToPow(3), 3);
      var eToFive = Math.Round(MathExtended.eToPow(5), 2);
      Console.WriteLine(eToOne);
      Console.WriteLine(eToThree);
      Console.WriteLine(eToFive);
      var diffOne = Math.Abs(eToOne - Math.Pow(Math.E, 1));
      var diffThree = Math.Abs(eToThree - Math.Pow(Math.E, 3));
      var diffFive = Math.Abs(eToFive - Math.Pow(Math.E, 5));
      Console.WriteLine("Diff: " + diffOne + ", Percent Error: " + diffOne / Math.Pow(Math.E, 1) * 100);
      Console.WriteLine("Diff: " + diffThree + ", Percent Error: " + diffThree / Math.Pow(Math.E, 3) * 100);
      Console.WriteLine("Diff: " + diffFive + ", Percent Error: " + diffFive / Math.Pow(Math.E, 5) * 100);
      Console.ReadKey();
    }
  }
}
