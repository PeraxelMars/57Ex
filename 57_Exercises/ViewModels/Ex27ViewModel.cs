using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using _57_Exercises.Helpers;

namespace _57_Exercises.ViewModels
{
    public class Ex27ViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 2)]
        [Display(Name = "Fist name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 2)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[A-Z]{2}-\\d{4}$", ErrorMessage = "The format must be 'XX-nnnn', Ex: 'AA-1234'")]
        [Placeholder("AA-1234")]
        public string EmployeeId { get; set; }

        [Required]
        [RegularExpression("^[\\d]{5}|[\\d ]{6}$", ErrorMessage = "The ZIP must be five numbers.")]
        [Placeholder("12345")]
        public string ZIP { get; set; }
    }
}