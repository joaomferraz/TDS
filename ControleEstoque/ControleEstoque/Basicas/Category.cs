
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ControleEstoque.Modelo.Basicas;

public class CategoryModel
{
    public int? CategoryID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public CategoryModel(int id, string name, string description)
    {
        CategoryID = id;
        Name = name;
        Description = description;
    }

    public CategoryModel(){

    }

    public override string ToString()
    {
        return $"[{CategoryID}, {Name}, {Description}]";
    }


    public override bool Equals(object? obj)
    {
        if (obj is CategoryModel other){

        return other.CategoryID == CategoryID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return CategoryID.GetHashCode();
    }
}

 