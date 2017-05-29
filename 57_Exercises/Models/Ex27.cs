using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex27
    {
        [StringLength(255, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(255, MinimumLength = 2)]
        public string LastName { get; set; }

        [RegularExpression("^[A-Z]{2}-\\d{4}$", ErrorMessage = "The format must be 'NN-dddd', Ex: 'AA-1234'")]
        public string EmployeeId { get; set; }


        [RegularExpression("^\\d{5}$", ErrorMessage = "The ZIP must be five numbers.")]
        public string ZIP { get; set; }
    }
}