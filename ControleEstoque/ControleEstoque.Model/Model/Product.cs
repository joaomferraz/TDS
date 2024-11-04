namespace ControleEstoque.Model.Model;

public class Product
{
    public int ProductID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int QuantityStock { get; set; }
    public Supplier? Supplier { get; set; }
    public CategoryModel? Category { get; set; }

    public Product(int id, string name, string description, decimal price, int quantityStock, Supplier supplier, CategoryModel category)
    {
        ProductID = id;
        Name = name;
        Description = description;
        Price = price;
        QuantityStock = quantityStock;
        Supplier = supplier;
        Category = category;
    }

    public Product()
    {
    }

    public override string ToString()
    {
        return $"[{ProductID}, {Name}, {Description}, {Price}, {QuantityStock}, {Supplier}, {Category}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Product other)
        {
            return other.ProductID == ProductID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ProductID.GetHashCode();
    }

}