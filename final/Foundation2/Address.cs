// Class Address
//     Attributes:
//         _streetAddress: string
//         _city: string
//         _stateOrProvince: string
//         _country: string
//     Constructors:
//         Address(_streetAddress, _city, _stateOrProvince, _country)
//     Methods:
//         IsInUSA(): bool
//         ToString(): string

namespace Foundation2.Classes
{
    // Define Class
    class Address
    {
        // Attributes
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        // Constructors
        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        // Methods
        public bool IsInUSA()
        {
            return _country == "USA";
        }

        public override string ToString()
        {
            return $"{_streetAddress}\n{_city}, {_stateOrProvince} {_country}";
        }
    }
}