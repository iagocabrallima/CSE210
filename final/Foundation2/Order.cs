// Class Order
//     Attributes:
//         _customer: Customer
//         _products: List<Product>
//     Constructors:
//         Order(_customer, _products)
//     Methods:
//         CalculateTotalCost(): double
//         ChooseShipping(): double
//         CreatePackingLabel(): string
//         CreateShippingLabel(): string
//         Display(): void

namespace Foundation2.Classes
{
    // Define Class
    class Order
    {
        // Attributes
        private Customer _customer;
        private List<Product> _products;

        // Constructors
        public Order(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products = products;
        }

        // Methods
        public double CalculateTotalCost()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.CalculateCost();
            }
            return total + ChooseShipping();
        }

        private int ChooseShipping()
        {
            return _customer.LivesInUSA() ? 5 : 35;
        }

        private string CreatePackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in _products)
            {
                packingLabel += product.ToString() + "\n";
            }
            return packingLabel
                + $"Shipping: ${ChooseShipping()}.00\nTotal cost: ${CalculateTotalCost().ToString("n2")}\n";
        }

        private string CreateShippingLabel()
        {
            return _customer.ToString() + "\n";
        }

        public void Display()
        {
            Console.WriteLine(CreatePackingLabel());
            Console.WriteLine(CreateShippingLabel());
        }
    }
}