namespace ControleEstoque.Model.Model;

public class PositionTitleModel
{
    public int PositionID { get; set; }
    public string? Description { get; set; }
    public float BaseSalary { get; set; }

    public PositionTitleModel(int id, string description, float baseSalary)
    {
        PositionID = id;
        Description = description;
        BaseSalary = baseSalary;
    }

    public PositionTitleModel()
    {
    }

    public override string ToString()
    {
        return $"[{PositionID}, {Description}, {BaseSalary}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is PositionTitleModel other)
        {
            return other.PositionID == PositionID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return PositionID.GetHashCode();
    }

}