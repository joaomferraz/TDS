namespace ControleEstoque.Model.Model;

public class Supplier
{
    public int SupplierID { get; set; }
    public string? Name { get; set; }
    public string? Cellphone { get; set; }
    public string? Address { get; set; }
    public List<Product>? Product { get; set; }

    public Supplier(int suplierID, string name, string cellphone, string address, List<Product> product)
    {
        SupplierID = suplierID;
        Name = name;
        Cellphone = cellphone;
        Address = address;
        Product = product;
    }

    public Supplier()
    {
    }

    public override string ToString()
    {
        return $"[{SupplierID}, {Name}, {Cellphone}, {Address}, {Product}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Supplier other)
        {
            return other.SupplierID == SupplierID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return SupplierID.GetHashCode();
    }
}