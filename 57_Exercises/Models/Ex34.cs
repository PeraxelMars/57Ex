using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex34
    {
        private static readonly ICollection<string> NameList;
        static Ex34()
        {
            NameList = new Collection<string>
            {
                "Bob",
                "Bob",
                "Olle",
                "Kalle",
                "Sven",
                "Göran"
            };
        }

        public static IEnumerable<string> GetNames()
        {
            return NameList;
        }

        public static void RemoveName(string name)
        {
            NameList.Remove(name);
        }
    }
}