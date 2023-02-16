using System;

class Program
{
    static void Main(string[] args)
    {
        // Product Choices
        Product product1 = new Product("Apples", "A7293", 1.5, 12);
        Product product2 = new Product("Bananas", "B2171", .75, 8);
        Product product3 = new Product("Carrots", "C0953", .25, 16);
        Product product4 = new Product("Dragon Fruit", "D8451", 2.5, 4);
        Product product5 = new Product("Eggplant", "E6753", .99, 2);
        Product product6 = new Product("Figs", "F6328", .3, 5);
        Product product7 = new Product("Grapefruit", "G9749", 1.2, 10);
        Product product8 = new Product("Honeydew", "H4480", 1.75, 6);
        Product product9 = new Product("Iceberg Lettuce", "I6466", 1.45, 8);
        Product product10 = new Product("Jicama", "J3290", 3, 2);
        Product product11 = new Product("Kiwi", "K6277", .65, 8);
        Product product12 = new Product("Lemons", "L2464", .35, 9);
        Product product13 = new Product("Mangos", "M9654", 1.3, 4);
        Product product14 = new Product("Nuts", "N5572", 2.25, 7);
        Product product15 = new Product("Oranges", "O8865", .9, 12);
        Product product16 = new Product("Pineapple", "P8977", 2.75, 5);
        Product product17 = new Product("Raspberries", "R0751", 2.4, 10);
        Product product18 = new Product("Squash", "S9422", 1.9, 4);
        Product product19 = new Product("Tangerines", "T6110", 1.15, 5);
        Product product20 = new Product("Watermelon", "W8436", 2.3, 3);

        // Customers
        // Customer 1
        Address address1 = new Address("1250 US Highway", "Venice", "FL", "34285", "USA");
        string newAddress1 = address1.GetAddress();
        string newCountry1 = address1.GetCountry();
        Customer customer1 = new Customer("Detwiler's Farm Market", $"{newAddress1}", $"{newCountry1}");

        // Customer 2
        Address address2 = new Address("27 cours Massena", "Antibes", "", "06600", "France");
        string newAddress2 = address2.GetAddress();
        string newCountry2 = address2.GetCountry();
        Customer customer2 = new Customer("Marche Provencal", $"{newAddress2}", $"{newCountry2}");

        // Customer 3
        Address address3 = new Address("85 Pike St", "Seattle", "WA", "98101", "USA");
        string newAddress3 = address3.GetAddress();
        string newCountry3 = address3.GetCountry();
        Customer customer3 = new Customer("Pike Palace Market", $"{newAddress3}", $"{newCountry3}");

        // Orders
        Order order1 = new Order();
        order1._customer = customer1.DisplayCustomer();
        order1._shippingCost = customer1.GetShippingCost();
        order1._products.Add(product1);
        order1._products.Add(product2);
        order1._products.Add(product3);
        order1._products.Add(product4);
        order1._products.Add(product5);
        order1._products.Add(product6);
        order1._products.Add(product7);

        Order order2 = new Order();
        order2._customer = customer2.DisplayCustomer();
        order2._shippingCost = customer2.GetShippingCost();
        order2._products.Add(product8);
        order2._products.Add(product9);
        order2._products.Add(product10);
        order2._products.Add(product11);
        order2._products.Add(product12);
        order2._products.Add(product13);

        Order order3 = new Order();
        order3._customer = customer3.DisplayCustomer();
        order3._shippingCost = customer3.GetShippingCost();
        order3._products.Add(product14);
        order3._products.Add(product15);
        order3._products.Add(product16);
        order3._products.Add(product17);
        order3._products.Add(product18);
        order3._products.Add(product19);
        order3._products.Add(product20);

        // Menu
        int content = 0;
        while (content != 4)
        {
            Console.WriteLine();
            Console.WriteLine("What can we do for you?");
            Console.WriteLine("  1. Get Total Price of an Order");
            Console.WriteLine("  2. Get Packing Label for an Order");
            Console.WriteLine("  3. Get Shipping Label of an Order");
            Console.WriteLine("  4. Quit Program");
            Console.Write("(please pick one) ");
            content = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (content != 4)
            {
                Console.WriteLine($"There are a total of 3 orders.");
                Console.Write("Which Order # did you want this for? ");
                int orderNumber = int.Parse(Console.ReadLine());
                Console.Clear();
                string order = $"order{orderNumber}";

                // Get what the user asked for
                if (content == 1) {
                    if (orderNumber == 1) {
                        order1.DisplayTotalPrice();
                    }
                    else if (orderNumber == 2) {
                        order2.DisplayTotalPrice();
                    }
                    else if (orderNumber == 3) {
                        order3.DisplayTotalPrice();
                    }
                }
                else if (content == 2) {
                    if (orderNumber == 1) {
                        order1.GetPackingLabel();
                    }
                    else if (orderNumber == 2) {
                        order2.GetPackingLabel();
                    }
                    else if (orderNumber == 3) {
                        order3.GetPackingLabel();
                    }
                }
                else if (content == 3) {
                    if (orderNumber == 1) {
                        order1.GetShippingLabel();
                    }
                    else if (orderNumber == 2) {
                        order2.GetShippingLabel();
                    }
                    else if (orderNumber == 3) {
                        order3.GetShippingLabel();
                    }
                }
            }
        }
    }
}