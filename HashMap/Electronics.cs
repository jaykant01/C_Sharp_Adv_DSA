using System;
using System.Collections.Generic;
namespace HashMap;

public interface IProduct
{
    string GetName();
    decimal GetPrice();
}


public class Electronics : IProduct
{
    private string name;
    private decimal price;

    public Electronics(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName() => name;
    public decimal GetPrice() => price;
}

public class Clothing : IProduct
{
    private string name;
    private decimal price;

    public Clothing(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName() => name;
    public decimal GetPrice() => price;
}


public class InventoryManager
{
    private Dictionary<int, IProduct> inventory = new Dictionary<int, IProduct>();

    public void AddProduct(int productId, IProduct product)
    {
        inventory[productId] = product;
        Console.WriteLine($"Product {product.GetName()} added with ID {productId}.");
    }

    public IProduct GetProduct(int productId)
    {
        if (inventory.TryGetValue(productId, out IProduct product))
        {
            return product;
        }
        Console.WriteLine("Product not found.");
        return null;
    }
}
