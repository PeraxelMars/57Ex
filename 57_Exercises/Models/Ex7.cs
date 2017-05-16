using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex7
    {
        public static double ConversionFactor = 0.09290304D;
        public Ex7(double length, double width, string option)
        {
            Length = length;
            Width = width;
            Option = option;
        }
        public double Length { get; private set; }
        public double Width { get; private set; }

        public string Option { get; private set; }

        public double GetAreaInSquareFeet()
        {
            var value = Length * Width;
            if (Option != "sqFeet")
            {
                value = value / ConversionFactor;
            }

            return value;
        }

        public double GetAreaInSquareMeter()
        {
            var value = Length * Width;

            if (Option == "sqFeet")
            {
                value = value * ConversionFactor;
            }
            return value;
        }

    }

}