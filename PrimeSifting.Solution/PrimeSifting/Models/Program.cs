using System;
using PrimeSifting.Models;
using System.Collections.Generic;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      string input = "";
      while (input != "quit")
      {
        input = GetInput("Enter a number: ");
        int max = 0;
        if (int.TryParse(input, out max))
        {
          string output = "Primes: ";
          List<int> primes = Prime.GetPrimes(max);
          foreach (int prime in primes)
          {
            output += prime + ", "; 
          }

          Console.WriteLine(output.Substring(0, output.Length - 2));
        }
        else if (input != "quit")
        {
          Console.WriteLine("Invalid input ('quit' to exit program)");
        }
      }
    }

    private static string GetInput(string message)
    {
      Console.Write(message);
      string input = Console.ReadLine();
      input = input.ToLower();
      return input.Trim();
    }
  }
}
