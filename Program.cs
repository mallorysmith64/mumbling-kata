using System;
using System.Linq;

namespace mumbling_kata
{
  public class Accumul
  {
    public static String Accum(string s)
    {
      //made variable
      var result = s.Split("").Select((letter, index) =>
      {
        //return variable as uppercase then lowercase letters and then repeat that
        return letter.ToUpperCase() + letter.ToLowerCase()
        .Enumerable.repeat(index);
        //add hyphen between letters when repeating letters is done
      }); 'string.Join(string, params s[])';
      //   string.Join("-");

      Console.WriteLine(result);
      return result;
    }
  }
}
static void Main(string[] args)
{
  Console.WriteLine("Hello World!");
}
