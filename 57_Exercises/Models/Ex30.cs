using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex30
    {
        public static IEnumerable<IEnumerable<int>> GenerateMultiTable0to12()
        {
            var result = GenerateTable(1, 20);
            return result;
        }

        private static IEnumerable<IEnumerable<int>> GenerateTable(int from, int to)
        {
            to++;
            List<List<int>> result = new List<List<int>>();

            for (int i = from; i < to; i++)
            {
                List<int> values = new List<int>();
                for (int k = from; k < to; k++)
                {
                    values.Add(i*k);
                }

                result.Add(values);
            }

            return result;
        }
    }
}