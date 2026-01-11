using System.Globalization;

namespace ProductPolymorphism.Entities;

public class ImportedProduct: Product
{ 
    public Double CustomsFee { get; set; }   
    
    public ImportedProduct(){}
    
    public ImportedProduct(string name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public Double TotalPrice()
    {
        return Price + CustomsFee;
    }
    
    override public string PriceTag()
    {
        return $"{Name} $:{TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $:{CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
    }
    
}