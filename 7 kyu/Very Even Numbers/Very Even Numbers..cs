public class Kata
{
  public static bool IsVeryEvenNumber(int number)
  {
      while(number >= 10)
  { 
          number = number % 10 + number / 10;
      }
      return number % 2 == 0;
  }
}