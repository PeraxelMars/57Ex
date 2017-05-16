using System;

namespace _57_Exercises.Models
{
    public class Ex9
    {
        private const float SquareMetersPerLiterPaint = 3.5F;

        private readonly int _width;
        private readonly int _length;

        public Ex9(int width, int length)
        {
            this._width = width;
            this._length = length;
        }

        public int GetPaintNeeded()
        {
            var paint = (_width * _length) / SquareMetersPerLiterPaint;

            return (int)Math.Ceiling(paint);
        }
    }
}