public class Kata
{
  public static int FindDifference(int[] a, int[] b)
  {
 int firstCub = 0;
 int secondCub = 0;
 firstCub = a[0] * a[1] * a[2];
 secondCub = b[0] * b[1] * b[2];
 if (firstCub > secondCub)
 
 return firstCub - secondCub;
 
 else if (secondCub > firstCub)
 
 return secondCub - firstCub;
 
 return 0;
    //loading...
    
  }
}