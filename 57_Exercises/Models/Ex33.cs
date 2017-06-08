using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public static class Ex33
    {
        private static readonly IList<string> _answers;
        static Ex33()
        {
            _answers = new List<string>
            {
                "Yes",
                "No",
                "Maybe",
                "Ask again later."
            };
        }

        public static string GetAnswer()
        {
            Random rand = new Random(DateTime.Now.Second);

            return _answers[rand.Next(0, 4)];
        }
    }
}