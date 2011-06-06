using System;
using System.Collections.Generic;

namespace CodeKata
{
  public class Calculator
  {
    public int add(string numbers)
    {
      const string custom_delim_prefix = "\\";
      
      if (numbers == string.Empty)
      {
        return 0;
      }

      int sum;

      string[] nums;

      char[] delims = new char[2];

      nums = numbers.Split('\n');
      if (LeftRightMid.Left(nums[0], 2) == custom_delim_prefix)
      {
        char newDelim = nums[0].Replace(custom_delim_prefix, "").ToCharArray()[0];
        delims[0] = newDelim;
      }
      else
      {
        delims[0] = ',';
      }
      delims[1] = '\n';

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