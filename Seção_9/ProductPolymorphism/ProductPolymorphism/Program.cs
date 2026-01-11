using System.ComponentModel;
using System.Globalization;
using ProductPolymorphism.Entities;


Console.Write("Enter the number of products:");
int numberProducts = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();

for (int i = 0; i < numberProducts; i++)
{
    Console.WriteLine($"Product #{i + 1}:");
    Console.Write("Common, used or imported (c/u/i)?");
    string typeProduct = Console.ReadLine();
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Price:");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (typeProduct == "i")
    {
        Console.Write("Customs fee:");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsFee));
        
    }else if (typeProduct == "c")
    {
        products.Add(new Product(name, price));
        
    }else
    {
        Console.Write("Manufacture date (DD/MM/YYYY):");
        DateTime manufacture = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name , price , manufacture));
        
    }
    
    Console.WriteLine("");
    Console.WriteLine("PRICE TAGS:");
    foreach (var VARIABLE in products)
    {
        Console.WriteLine(VARIABLE.PriceTag());
    }

}
Console.ReadKey();