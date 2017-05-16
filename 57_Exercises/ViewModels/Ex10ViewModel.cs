using System.Collections.Generic;

namespace _57_Exercises.ViewModels
{
    public class Ex10ViewModel
    {
        public int Item1Quantity { get; set; }
        public int Item1Price { get; set; }

        public int Item2Quantity { get; set; }
        public int Item2Price { get; set; }

        public int Item3Quantity { get; set; }
        public int Item3Price { get; set; }

        public float SubTotal { get; set; }

        public float Tax { get; set; }

        public float Total { get; set; }

        public IEnumerable<KeyValuePair<int, int>> ToKeyValuePairs()
        {
            IList<KeyValuePair<int, int>> values = new List<KeyValuePair<int, int>>();

            values.Add(new KeyValuePair<int, int>(Item1Quantity, Item1Price));
            values.Add(new KeyValuePair<int, int>(Item2Quantity, Item2Price));
            values.Add(new KeyValuePair<int, int>(Item3Quantity, Item3Price));

            return values;
        }
    }
}