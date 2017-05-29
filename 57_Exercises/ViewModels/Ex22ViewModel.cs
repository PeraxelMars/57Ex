using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.ViewModels
{
    public class Ex22ViewModel
    {

        public Ex22ViewModel()
        {
            Numbers = new List<int>();
        }

        public List<int> Numbers { get; set; }

        public int Largest { get; set; }
    }
}