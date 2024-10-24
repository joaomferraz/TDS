namespace ControleEstoque.Modelo.Basicas;

public class Employee : Person
{
    public int EmployeeID { get; set; }
    public PositionTitle? PositionTitle { get; set; }

    public Employee(int id, PositionTitle position)
    {
        EmployeeID = id;
        PositionTitle = position;

    }

    public Employee()
    {
    }

    public override string ToString()
    {
        return $"[{EmployeeID}, {PositionTitle}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Employee other)
        {
            return other.EmployeeID == EmployeeID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return EmployeeID.GetHashCode();
    }

}

