namespace HashMap;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        InventoryManager manager = new InventoryManager();

        manager.AddProduct(101, new Electronics("Laptop", 75000m));
        manager.AddProduct(102, new Clothing("T-Shirt", 499m));

        IProduct product1 = manager.GetProduct(101);
        if (product1 != null)
            Console.WriteLine($"Product 101: {product1.GetName()}, Price: {product1.GetPrice()}");

        IProduct product2 = manager.GetProduct(102);
        if (product2 != null)
            Console.WriteLine($"Product 102: {product2.GetName()}, Price: {product2.GetPrice()}");


        Console.ReadKey();
    }
}
