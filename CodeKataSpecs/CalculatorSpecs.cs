using System;
using CodeKata;
using Machine.Specifications;

namespace CodeKataSpecs
{
  [Subject(typeof (Calculator))]
  public class When_adding_a_string_of_numbers
  {
    private Establish context = 
      () =>
      {
      };

    private Because of = 
      () =>
      {
        calc = new Calculator();
      };

    private It should_return_0_when_passed_an_empty_string =
      () =>
        {
          sum = calc.add("");
          sum.ShouldEqual<int>(0);
        };

    private It should_return_4_when_passed_a_4 =
      () =>
      {
        sum = calc.add("4");
        sum.ShouldEqual<int>(4);
      };

    private It should_return_5_when_passed_2_and_3 =
      () =>
        {
          sum = calc.add("2,3");
          sum.ShouldEqual<int>(5);
        };

    private It should_return_17_when_passed_11_2_2_1_1 =
      () =>
      {
        sum = calc.add("11,2,2,1,1");
        sum.ShouldEqual<int>(17);
      };

    private It should_return_allow_line_feed_charaters =
      () =>
      {
        sum = calc.add("1\n2,3");
        sum.ShouldEqual<int>(6);
      };

    private It should_not_error_when_line_feed_charaters_is_the_last_term =
      () =>
      {
        sum = calc.add("2,1\n");
        sum.ShouldEqual<int>(3);
      }; 
    
    private static int sum;
    private static Calculator calc;
  }
}