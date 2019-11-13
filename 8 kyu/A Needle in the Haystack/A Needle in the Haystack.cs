using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  
  {
  for (int i=0; i<haystack.Length; i++)
  {
  if (haystack[i] == "needle")
  {
  string num = Convert.ToString(i);
  return "found the needle at position " + num;
  }
  }
  return "";
  //Code goes here!
  }
}