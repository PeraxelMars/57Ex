using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace _57_Exercises.Models
{
    public class Ex25
    {
        public static PasswordStrength ValidatePassword(string pw)
        {
            if(string.IsNullOrEmpty(pw))
                return PasswordStrength.Undefined;

            PasswordStrength strength;

            if (pw.Length < 8)
            {
                strength = int.TryParse(pw, out int temp) ?
                                PasswordStrength.VeryWeak : PasswordStrength.Weak;
            }

            else
            {
                strength = pw.All(char.IsLetterOrDigit) ?
                                PasswordStrength.Strong : PasswordStrength.VeryStrong;
            }

            return strength;
        }
    }

    public enum PasswordStrength
    {
        Undefined,
        [Display(Name = "Very weak")]
        VeryWeak,
        Weak,
        Strong,
        [Display(Name = "Very strong")]
        VeryStrong
    }
}