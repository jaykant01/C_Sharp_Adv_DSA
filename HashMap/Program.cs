namespace HashMap;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //InventoryManager manager = new InventoryManager();

        //manager.AddProduct(101, new Electronics("Laptop", 75000m));
        //manager.AddProduct(102, new Clothing("T-Shirt", 499m));

        //IProduct product1 = manager.GetProduct(101);
        //if (product1 != null)
        //    Console.WriteLine($"Product 101: {product1.GetName()}, Price: {product1.GetPrice()}");

        //IProduct product2 = manager.GetProduct(102);
        //if (product2 != null)
        //    Console.WriteLine($"Product 102: {product2.GetName()}, Price: {product2.GetPrice()}");


        // Problem 2
        //AuthSystem auth = new AuthSystem();

        //auth.AssignRole("Alice", new AdminRole());
        //auth.AssignRole("Bob", new UserRole());
        //auth.AssignRole("Charlie", new ManagerRole());

        //Console.WriteLine("Alice can delete? " + auth.CheckAccess("Alice", "delete"));
        //Console.WriteLine("Bob can write? " + auth.CheckAccess("Bob", "write"));
        //Console.WriteLine("Charlie can write? " + auth.CheckAccess("Charlie", "write"));


        // Problem 3
        //GradeService gradeService = new GradeService();

        //gradeService.AddGrade(101, new CBSEGradeReport());
        //gradeService.AddGrade(102, new GPAGradeReport());

        //gradeService.DisplayGrade(101, 88); 
        //gradeService.DisplayGrade(102, 88);


        // Problem 4
        IURLStorage storage = new InMemoryURLStorage();

        storage.PutURL("abc123", "https://www.example.com/very-long-url");
        storage.PutURL("xyz789", "https://www.anotherexample.com/page");

        string longUrl1 = storage.GetURL("abc123");
        Console.WriteLine("Long URL for abc123: " + longUrl1);

        string longUrl2 = storage.GetURL("xyz789");
        Console.WriteLine("Long URL for xyz789: " + longUrl2);

        string longUrl3 = storage.GetURL("notfound");
        Console.WriteLine("Long URL for notfound: " + longUrl3);

        Console.ReadKey();
    }
}
