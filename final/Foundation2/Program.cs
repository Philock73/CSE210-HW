using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _orders = new List<Order>
        {
            
        };
        Address myAddress = new Address("151 S Western", "Rexburg", "NH", "USA");
        Customer myFirstCustomer = new Customer("Phil Bedin", myAddress);
        Order myOrder = new Order();
        _orders.Add(myOrder);
        Order hisOrder = new Order();
        _orders.Add(hisOrder);
        Product firstProduct = new Product("Laundry detergent", 9925, 25, 2);
        Product secondProduct = new Product("MTG Cards", 0053, 5, 24);
        Product thirdProduct = new Product("Tolet Paper", 6585, 22, 1);
        Product fourthProduct = new Product("Goldfish", 4576, 11, 3);
        Product fifthProduct = new Product("TV", 9999, 1699, 1);
        myOrder.LoadProducts(fifthProduct);
        myOrder.LoadProducts(firstProduct);
        myOrder.LoadProducts(thirdProduct);
        hisOrder.LoadProducts(secondProduct);
        hisOrder.LoadProducts(firstProduct);
        hisOrder.LoadProducts(fourthProduct);

        foreach(Order order in _orders)
        {
            List<Product> _products = order.ReturnPackingLabel();
            string shippingLable = order.ReturnShippingLabel(myFirstCustomer);
            int total = order.TotalPrice();
            Console.WriteLine($"The shipping lable is\n{shippingLable}.");
            foreach(Product product in _products)
            {
                Console.WriteLine(product.PackingLable());
            }
            Console.WriteLine($"Your total price is ${total}");
        }
    }
}