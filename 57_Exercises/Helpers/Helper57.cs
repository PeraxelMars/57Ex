using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Helpers
{
    public class Helper57
    {
        public static IEnumerable<string> _5_DoTheMath(double a, double b)
        {
            List<string> result = new List<string>();

            var addition = a + b;
            var subtraction = a - b;
            var multiplication = a * b;
            var division = a / b;

            result.Add($"{a} + {b} = {addition}");
            result.Add($"{a} - {b} = {subtraction}");
            result.Add($"{a} * {b} = {multiplication}");
            result.Add($"{a} / {b} = {division}");

            return result;
        }

        public static IEnumerable<string> _6_DoTheMath(int age, int retirementAge)
        {
            List<string> result = new List<string>();
            if (retirementAge < age)
            {
                result.Add("You can already retire!");
            }
            else
            {
                var currentYear = DateTime.Now.Year;


                result.Add($"You have {retirementAge - age} years left until you can retire.");
                result.Add($"It is {currentYear} so you can retire in {retirementAge - age + currentYear}.");
            }

            return result;
        }
    }
}