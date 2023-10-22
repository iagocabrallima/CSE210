// Class Product
//     Attributes:
//         _name: string
//         _id: int
//         _price: double
//         _quantity: int
//     Constructors:
//         Product(_name, _id, _price, _quantity)
//     Methods:
//         CalculateCost(): double
//         ToString(): string

namespace Foundation2.Classes
{
    // Define Class
    class Product
    {
        // Attributes
        private string _name;
        private int _id;
        private double _price;
        private int _quantity;

        // Constructors
        public Product(string name, int id, double price, int quantity)
        {
            _name = name;
            _id = id;
            _price = price;
            _quantity = quantity;
        }

        // Methods
        public double CalculateCost()
        {
            return _price * _quantity;
        }

        public override string ToString()
        {
            return $"{_name} (Product #{_id}) - {_quantity} @ ${_price.ToString("n2")} - {CalculateCost().ToString("n2")}";
        }
    }
}