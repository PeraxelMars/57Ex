using System;
using System.Linq;

namespace _57_Exercises.Models
{
    public class Ex24
    {
        private readonly string _s1;
        private readonly string _s2;

        public Ex24(string s1, string s2)
        {
            _s1 = s1;
            _s2 = s2;
        }

        public bool IsAnagram
        {
            get
            {
                if (String.Compare(_s1, _s2, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    return false;
                }
                var s1 = string.Concat(_s1.OrderBy(s => s));
                var s2 = string.Concat(_s2.OrderBy(s => s));

                return String.Compare(s1, s2, StringComparison.InvariantCultureIgnoreCase) == 0;
            }
        }
    }
}