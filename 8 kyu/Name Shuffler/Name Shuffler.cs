using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
  string[] shuff = str.Split(" ");
  return shuff[1] + " " + shuff[0];
  }
}