using System;
using Foundation2.Classes;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Ball bearing (0.5in)", 3904, 2.99, 4));
        products1.Add(new Product("Sign post", 2440, 15.79, 10));
        products1.Add(new Product("TV screen", 18080, 45.39, 2));
        Address address1 = new Address("1234 Sesame St", "Sugar City", "Ontario", "Canada");
        Customer customer1 = new Customer("Tyler Vistaunet", address1);
        orders.Add(new Order(customer1, products1));

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Linear Algebra textbook", 8898, 35.99, 1));
        products2.Add(new Product("Backpack", 1101, 19.99, 1));
        products2.Add(new Product("Sneakers", 28080, 89.99, 2));
        Address address2 = new Address("84 S Tumtum Rd", "Athabasca", "Alaska", "USA");
        Customer customer2 = new Customer("Alexander Perazzo", address2);
        orders.Add(new Order(customer2, products2));

        List<Product> products3 = new List<Product>();
        products3.Add(new Product("Table leg", 9544, 13.99, 4));
        products3.Add(new Product("Nikon camera", 11440, 74.99, 1));
        products3.Add(new Product("Can opener", 1907, 8.99, 2));
        Address address3 = new Address("909B Ruffalo Rd", "Romania", "Nebraska", "USA");
        Customer customer3 = new Customer("Addison Allison", address3);
        orders.Add(new Order(customer3, products3));

        foreach (Order order in orders)
        {
            order.Display();
        }
    }
}