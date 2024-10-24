
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ControleEstoque.Modelo.Basicas;

public class CategoriaModelo
{
    public int? CategoriaID { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }

    public CategoriaModelo(int categoriaID, string nome, string descricao)
    {
        CategoriaID = categoriaID;
        Nome = nome;
        Descricao = descricao;
    }

    public CategoriaModelo(){

    }

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

 