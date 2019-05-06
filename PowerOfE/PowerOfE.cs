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
      double error = Math.Pow(10, -7);
      int iterations = 10000;
      double sum = 0;
      double trueValue = Math.Pow(Math.E, power);
      for (int i = 0; i < iterations; i++)
      {
        if (Math.Abs(sum - trueValue) < error)
        {
          Console.WriteLine($"Steps: {i + 1}");
          break;
        }
        //Console.WriteLine(toPow(power, i).ToString() + " / " + factorial(i));
        sum += toPow(power, i) / factorial(i);
      }
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
