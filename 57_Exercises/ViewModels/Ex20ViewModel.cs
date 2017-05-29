using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using _57_Exercises.Models;

namespace _57_Exercises.ViewModels
{
    public class Ex20ViewModel
    {
        [Required]
        [DisplayName("Order amount")]
        public int? OrderAmount { get; set; }

        public decimal TaxRate { get; set; }

        public IEnumerable<SelectListItem> States { get; set; }

        [Required]
        public string State { get; set; }

        public string County { get; set; }

        public Months Months { get; set; }
    }
}