using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using _57_Exercises.Models;

namespace _57_Exercises.ViewModels
{
    public class Ex18ViewModel
    {
        [Required]
        public int Temperature { get; set; }

        [Required]
        public string TempScale { get; set; }

        public string TempInCelsius { get; set; }
        public string TempInFarenheight { get; set; }
    }
}