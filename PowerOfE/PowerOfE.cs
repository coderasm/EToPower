using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfE
{
  class MathExtended
  {
    public static double eToPow(int power)
    {
      var sums = 13;
      double sum = 0;
      for (int i = 0; i < sums; i++)
      {
        //Console.WriteLine(toPow(power, i).ToString() + " / " + factorial(i));
        sum += (double)toPow(power, i) / factorial(i);
      }
      return sum;
    }

    static int toPow(int baseNum, int power)
    {
      if (power == 0)
        return 1;
      return baseNum * toPow(baseNum, power - 1);
    }
    
    static int factorial(int number)
    {
      if (number <= 1)
        return 1;
      return number * factorial(number - 1);
    }
  }
}
