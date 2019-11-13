public class Kata
{
  public static string Well(string[] x)
  {
  int countGood=0;
  for (int i=0; i<x.Length; i++)
  {
  if (x[i] == "good")
  countGood++;
  }
  if (countGood >0 && countGood <=2)
  return "Publish!";
  else if (countGood>2)
  return "I smell a series!";
  else
  return "Fail!";
  }
}