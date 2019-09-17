using System;
using System.Linq;

namespace mumbling_kata
{
  public class Accumul
  {
    public String Accum(string s)
    {
      return string.Join("-",
                  s.Select((a, b) => ToUpper(s.ToCharArray()[b]) + ToLower(s.ToCharArray()[b], b)).ToList());
    }
    private static string ToLower(char accumChar, int repeat)
    {
      return new string(char.ToLower(accumChar), repeat);
    }
    private static string ToUpper(char accumChar)
    {
      return accumChar.ToString().ToUpper();
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
