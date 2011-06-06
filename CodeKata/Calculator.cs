using System;
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

      string[] nums;

      char[] delims = new char[2];

      delims[0] = ',';
      delims[1] = '\n';

      //"1\n2,3"

      sum = 0;
      nums = numbers.Split(delims);

      foreach (var s in nums)
      {

        if (!String.IsNullOrEmpty(s))
          sum = sum + int.Parse(s);
      }
  
      return sum;

    }
  }
}