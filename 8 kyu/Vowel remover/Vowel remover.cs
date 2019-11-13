public class Kata
{
  public static string Shortcut(string input)
  {
  string[] letters = {"a", "e", "i", "o", "u"};
  for (int i = 0; i<letters.Length; i++)
  {
  input = input.Replace(letters[i], "");
  }
  return input;
    
  }
}