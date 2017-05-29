namespace _57_Exercises.Models
{
    public class Ex20
    {
        private readonly int _orderAmount;
        private readonly string _state;
        private readonly string _county;
        private decimal _taxRate;

        public Ex20(int orderAmount, string state, string county)
        {
            _orderAmount = orderAmount;
            _state = state;
            _county = county;
            _taxRate = 0M;

            SetTaxRate();
        }

        private decimal SetTaxRate()
        {
            if (_state == "Wisconsin")
            {
                if (_county == "Eau Claire")
                {
                    _taxRate = 0.005M;
                }
                else if(_county == "Dunn")
                {
                    _taxRate = 0.004M;
                }
            }
            else if(_state == "Illinois")
            {
                _taxRate = 0.08M;
            }

            return _taxRate;
        }

        public decimal GetTaxRate()
        {
            return _taxRate;
        }
    }
}