using System;
public class Kata
{
  public static int SumDigits(int number)
  {
    if (number <0)
    {
    number = number *(-1);
    }
    char[] characters = number.ToString().ToCharArray();
    string[] container = new string[characters.Length];
    int[] numbers = new int[characters.Length];
    int sum=0;
    for (int i = 0; i < characters.Length; i++)
    {
    container[i] = Convert.ToString(characters[i]);
    }
    for (int i = 0; i <  numbers.Length; i++)
    {
    numbers[i] = Convert.ToInt32(container[i]);
    }
    for (int i = 0; i < numbers.Length; i++)
    {
    sum = sum + numbers[i];
    }
    return sum;
  }
}