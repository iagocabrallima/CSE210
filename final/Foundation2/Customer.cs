// Class Customer
//     Attributes:
//         _name: string
//         _address: Address
//     Constructors:
//         Customer(_name, _address)
//     Methods:
//         LivesInUSA(): bool
//         ToString(): string

namespace Foundation2.Classes
{
    // Define Class
    class Customer
    {
        // Attributes
        private string _name;
        private Address _address;

        // Constructors
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        // Methods
        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }

        public override string ToString()
        {
            return $"Customer: {_name}\nAddress: {_address.ToString()}";
        }
    }
}