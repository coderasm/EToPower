using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfE
{
  class MathExtended
  {
    public static double eToPow(double power)
    {
      double epsilon = Math.Pow(10, -7);
      double sum = 1;
      var step = 1;
      double partialSum = 1;
      while (partialSum > epsilon)
      {
        partialSum = toPow(power, step) / factorial(step);
        if (double.IsNaN(partialSum) || double.IsPositiveInfinity(partialSum))
          break;
        sum += partialSum;
        ++step;
      }
      Console.Write($"Steps: {step + 1}");
      return sum;
    }

    static double toPow(double baseNum, int power)
    {
      double sum = 1;
      for (int i = 0; i < power; i++)
      {
        sum *= baseNum;
      }
      return sum;
      //if (power == 0)
      //  return 1;
      //return baseNum * toPow(baseNum, power - 1);
    }
    
    static double factorial(int number)
    {
      double sum = 1;
      for (int i = number; i > 1; i--)
      {
        sum *= i;
      }
      return sum;
      //if (number <= 1)
      //  return 1;
      //return number * factorial(number - 1);
    }
  }
}
