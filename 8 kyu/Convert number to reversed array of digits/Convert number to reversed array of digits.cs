using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
    char[] characters = n.ToString().ToCharArray();
    string[] container = new string[characters.Length];
    long[] numbers = new long[characters.Length];

    for (int i = 0; i < characters.Length; i++)
    {
    container[i] = Convert.ToString(characters[i]);
    }
    for (int i = 0; i <  numbers.Length; i++)
    {
    numbers[i] = Convert.ToInt32(container[i]);
    }
    Array.Reverse(numbers);
    return numbers;
    }
  }
}