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

      sum = 0;
      nums = numbers.Split(",".ToCharArray());
        
      foreach (var s in nums)
      {
        sum = sum + int.Parse(s);
      }
        
      return sum;

    }
  }
}