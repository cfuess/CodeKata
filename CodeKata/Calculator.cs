using System.Collections.Generic;

namespace CodeKata
{
  public class Calculator 
  {
    public int add(string numbers)
    {
      if (numbers == string.Empty)
      {      
        return 0;
      }

      int sum;
      //string[] nums;
      var nums = new List<string[]>();
      var splitchars = new List<char[]>();

      splitchars.Add(",".ToCharArray());
      splitchars.Add("\n".ToCharArray());


      //"1\n2,3"

      sum = 0;
      //nums = numbers.Split(splitchars);
      foreach (var s in splitchars)
      {
        nums.Add(numbers.Split(s));
      }

      foreach (var s in nums)
      {
        sum = sum + int.Parse(s);
      }
        
      return sum;

    }
  }
}