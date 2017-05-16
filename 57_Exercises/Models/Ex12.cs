using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex12
    {
        public readonly decimal _pricipal;
        private readonly float _rate;
        private readonly int _years;

        public Ex12(decimal pricipal, float rate, int years)
        {
            _years = years;
            _rate = rate / 100;
            _pricipal = pricipal;
        }

        public decimal CalculateInterest()
        {
            var result = _pricipal * (1 + _years * (decimal)_rate);

            return result;
        }
    }
}