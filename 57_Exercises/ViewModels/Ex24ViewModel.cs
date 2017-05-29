using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _57_Exercises.ViewModels
{
    public class Ex24ViewModel
    {
        [Required]
        public string S1 { get; set; }

        [Required]
        public string S2 { get ; set; }

        public bool IsAnagram { get; set; }
    }
}