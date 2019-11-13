public static class Kata
{
  public static int SquareSum(int[] n)
  { 
  int sum = 0;
  for(int i = 0; i<n.Length; i++)
  {
  sum = sum + (n[i]*n[i]);
  }
  return sum;
  }
}