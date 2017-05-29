using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex22
    {
        public Ex22(List<int> numbers)
        {
            Numbers = new SortedSet<int>(numbers);
        }

        public SortedSet<int> Numbers { get; set; }

        public int Largest => Numbers.Last();
    }
}