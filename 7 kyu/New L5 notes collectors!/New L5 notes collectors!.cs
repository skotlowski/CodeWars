public class Kata
{
  public static int GetNewNotes(int salary, int[] bills)
  {
  int plus = 0;
  for (int i=0; i<bills.Length; i++)
  {
  plus = bills[i] + plus;
  }
  
  int freeMoney = salary - plus;
  
  if (freeMoney >=5)
  return freeMoney/5;
  
  else 
  return 0;
  }
}