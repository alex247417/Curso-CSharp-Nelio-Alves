using System.Globalization;
using System.Runtime.InteropServices.JavaScript;

namespace ProductPolymorphism.Entities;

public class UsedProduct: Product
{
    DateTime Manufacture { get; set; }
    
    public UsedProduct()
    {
        
    }

    public UsedProduct(string name, double price, DateTime manufacture) : base(name, price)
    {
        Manufacture = manufacture;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) $:{Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {Manufacture.ToString("dd/MM/yyyy")})";
    }
}