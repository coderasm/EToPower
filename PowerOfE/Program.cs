using System;

namespace PowerOfE
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("####### Part B ########");
      var eToOne = Math.Round(MathExtended.eToPow(1), 5);
      Console.WriteLine($", Value: {eToOne}");
      var eToThree = Math.Round(MathExtended.eToPow(3), 3);
      Console.WriteLine($", Value: {eToThree}");
      var eToFive = Math.Round(MathExtended.eToPow(5), 2);
      Console.WriteLine($", Value: {eToFive}");
      var diffOne = Math.Abs(eToOne - Math.Pow(Math.E, 1));
      var diffThree = Math.Abs(eToThree - Math.Pow(Math.E, 3));
      var diffFive = Math.Abs(eToFive - Math.Pow(Math.E, 5));
      Console.WriteLine();
      Console.WriteLine("####### Part C ########");
      Console.WriteLine("Diff: " + diffOne.ToString("G3") + ", Percent Error: " + (diffOne / Math.Pow(Math.E, 1)).ToString("G3"));
      Console.WriteLine("Diff: " + diffThree.ToString("G3") + ", Percent Error: " + (diffThree / Math.Pow(Math.E, 3)).ToString("G3"));
      Console.WriteLine("Diff: " + diffFive.ToString("G3") + ", Percent Error: " + (diffFive / Math.Pow(Math.E, 5)).ToString("G3"));
      Console.WriteLine();
      Console.WriteLine("####### Part D ########");
      var eToHundred = Math.Round(MathExtended.eToPow(100), 3);
      Console.WriteLine($", Value: {eToHundred.ToString("G3")}");
      var eToThousand = Math.Round(MathExtended.eToPow(1000), 3);
      Console.WriteLine($", Value: {eToThousand.ToString("G3")}");
      var diffHundred = Math.Abs(eToHundred - Math.Pow(Math.E, 100));
      var diffThousand = Math.Abs(eToThousand - Math.Pow(Math.E, 1000));
      Console.WriteLine("Diff: " + diffHundred.ToString("G3") + ", Percent Error: " + (diffHundred / Math.Pow(Math.E, 100)).ToString("G3"));
      Console.WriteLine("Diff: " + diffThousand.ToString("G3") + ", Percent Error: " + (diffThousand / Math.Pow(Math.E, 1000)).ToString("G3"));
      Console.ReadKey();
    }
  }
}
