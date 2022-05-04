using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class Prime
  {
    public static List<int> GetPrimes(int max)
    {
      if (max < 2)
      {
        return new List<int> {};
      }
      else
      {
        List<int> numbers = CreateNumberArray(max);
        for (int i = 0; i < numbers.Count; i++)
        {
          for (int j = i + 1; j < numbers.Count; j++)
          {
            if (numbers[j] % numbers[i] == 0)
            {
              numbers.Remove(numbers[j]);
            }
          }
        }
        
        return numbers;
      }
    }

    private static List<int> CreateNumberArray(int max)
    {
      List<int> numbers = new List<int>();
      for (int i = 2; i <= max; i++)
      {
        numbers.Add(i);
      }

      return numbers;
    }
  }
}