using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
  int sum = on + wait;
  
  if (cap >= sum)
  return 0;
  
  else if (cap < sum)
  
  {
  if ( on > wait || on < wait)
  return ((on + wait) - cap);
  
  }
    throw new NotImplementedException();
  }
}