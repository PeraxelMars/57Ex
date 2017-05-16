using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _57_Exercises.Models
{
    public class Ex18
    {
        public Ex18(float temperature, TemeratureScale tempScale)
        {
            Scale = tempScale;
            Temperature = temperature;
        }

        public float Temperature { get; private set; }
        public TemeratureScale Scale { get; private set; }

        public float GetTempInCelcius()
        {
            if (Scale == TemeratureScale.Celsius)
                return Temperature;

            return (Temperature - 32) * 5 / 9;
        }

        public float GetTempInFarenheight()
        {
            if (Scale == TemeratureScale.Farenheit)
                return Temperature;

            return (Temperature * 9 / 5) + 32;
        }
    }

    public enum TemeratureScale
    {
        Celsius,
        Farenheit
    }
}