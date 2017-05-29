using System.ComponentModel.DataAnnotations;
using _57_Exercises.Models;

namespace _57_Exercises.ViewModels
{
    public class Ex25ViewModel
    {
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public PasswordStrength PasswordStrengt { get; set; }
    }
}