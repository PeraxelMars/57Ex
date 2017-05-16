using System;
using System.Collections.Generic;

namespace _57_Exercises.Models
{
    public class Ex10
    {
        private const float taxRate = 5.5F;
        private readonly IEnumerable<KeyValuePair<int, int>> _items;

        public Ex10(IEnumerable<KeyValuePair<int, int>> items)
        {
            _items = items;
        }

        public float GetSubTotal()
        {
            float subTotal = 0F;
            foreach (var item in _items)
            {
                subTotal += item.Key * item.Value;
            }

            return subTotal;
        }

        public float GetTax()
        {
            return GetSubTotal() * (taxRate/100);
        }

        public float GetTotal()
        {
            return GetSubTotal() + GetTax();
        }
    }
}