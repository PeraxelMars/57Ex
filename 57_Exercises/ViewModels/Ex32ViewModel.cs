using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _57_Exercises.Models;

namespace _57_Exercises.ViewModels
{
    public class Ex32ViewModel
    {
        [Required]
        [Range(1, 3, ErrorMessage = "Enter a number between 1 to 3")]
        [Display(Name = "Difficulty level")]
        public int DifficultyLevel { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Enter a number between 0 to 1000")]
        public int Answer { get; set; }

        [ScaffoldColumn(false)]
        public AnswerStatus AnswerStatus { get; set; }
    }
}