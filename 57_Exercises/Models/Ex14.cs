using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex14
    {
        private const decimal wiTax = 0.55m;
        private string _state;
        private decimal _amount;

        public Ex14(string state, decimal amount)
        {
            _state = state.ToLower();
            _amount = amount;
        }

        public string[] GetResult()
        {
            List<string> result = new List<string>();
            decimal tax = 0;

            if (_state == "wi")
            {
                result.Add($"The subtotal is: {_amount}");

                tax = _amount * wiTax;
                result.Add($"The tax is: {tax:C2}.");
            }

            result.Add($"The total is {(_amount + tax):C2}.");

            return result.ToArray();
        }
    }
}