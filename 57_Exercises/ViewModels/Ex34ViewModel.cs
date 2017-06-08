using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _57_Exercises.Models;

namespace _57_Exercises.ViewModels
{
    public class Ex34ViewModel
    {
        public IEnumerable<string> Names { get; set; }

        public void MapFromDomain(IEnumerable<string> entityModel)
        {
            Names = entityModel;
        }
    }
}