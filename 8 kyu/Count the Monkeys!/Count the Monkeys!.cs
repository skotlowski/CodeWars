public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
  int[] tab = new int[n];
  int counting =0;
  for(int i=0; i<n; i++)
  {
  counting++;
  tab[i] = counting;
  }
  return tab;
    
  }
}