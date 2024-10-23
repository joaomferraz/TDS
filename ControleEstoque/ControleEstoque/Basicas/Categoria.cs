
using System.Reflection.Metadata.Ecma335;

namespace ControleEstoque.Modelo.Basicas;

public class CategoriaModelo(int categoriaID, string nome, string descricao)
{


    public int? CategoriaID { get; set; } = categoriaID;
    public string? Nome { get; set; } = nome;

    public string? Descricao { get; set; } = descricao;
    
public override string ToString()
    {
        return $"[{CategoriaID}, {Nome}, {Descricao}]";
    }


    public override bool Equals(object? obj)
    {
        if (obj is CategoriaModelo other){

        return other.CategoriaID == CategoriaID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return CategoriaID.GetHashCode();
    }
}

 