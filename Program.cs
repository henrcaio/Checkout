using System;
using Checkout.Entities;
using Checkout.Entities.Enums;

namespace Checkout {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter customer data:\n");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime bdate = DateTime.Parse(Console.ReadLine());
            Customer customer = new Customer(name, email, bdate);

            Console.Write("\nEnter order data: \n");
            Console.WriteLine("Status (PENDING_PAYMENT,PROCESSING,SHIPPED OR DELIVERED): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, customer);
            Console.Write("\nHow many items are there? ");
            int n  = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.Write("\nProduct Name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double pprice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int pquant = int.Parse(Console.ReadLine());
                Product product = new Product(pname, pprice);
                OrderItem orderItem = new OrderItem(pquant, pprice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("\nSUMMARY:");
            Console.WriteLine(order);

        }
    }
}
