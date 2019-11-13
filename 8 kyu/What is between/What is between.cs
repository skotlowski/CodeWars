using System;
using System.Linq;

 public static class Kata
    {
    
        public static int[] Between(int a, int b)
        {
        int counting = 0;
        
        for (int count = a; count<=b;count++)
        {
        
        counting++;
        
        }
      
        int[] tab = new int[counting];
        int i = 0;
        
        for (int c = a; c<=b;c++)
        
        {  
        tab[i] = c;
        i++;
        }
        
        return tab;
        }
    }