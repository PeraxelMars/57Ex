using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace _57_Exercises.ViewModels
{
    public class Ex14ViewModel
    {
        [Required]
        public string State { get; set; }

        [Required]
        [RegularExpression("^\\d+[,|\\.]?\\d+$")]
        public string Amount { get; set; }

        public string[] Result { get; set; }
    }
}