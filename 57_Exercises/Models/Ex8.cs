using System;

namespace _57_Exercises.Models
{
    public class Ex8
    {
        private readonly int _people;
        private readonly int _pizzas;
        private readonly int _slicesPerPizza;

        public Ex8(int people, int pizzas, int slicesPerPizza)
        {
            _people = people;
            _pizzas = pizzas;
            _slicesPerPizza = slicesPerPizza;
        }

        public int GetSlicesPerPerson()
        {
            var slicesPerPerson = (_pizzas * _slicesPerPizza) / _people;
            return slicesPerPerson;
        }


        public int GetLeftOvers()
        {
            var totalSlices = _pizzas * _slicesPerPizza;
            var leftOvers = totalSlices - (GetSlicesPerPerson() * _people);
            return leftOvers;
        }
    }
}