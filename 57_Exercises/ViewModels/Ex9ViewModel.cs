using System;
using _57_Exercises.Models;

namespace _57_Exercises.ViewModels
{
    public class Ex9ViewModel
    {
        public int Width { get; set; }
        public int Length { get; set; }

        public int SquareMeters => Width * Length;
        public int CansOfPaintNeeded { get; set; }
    }
}