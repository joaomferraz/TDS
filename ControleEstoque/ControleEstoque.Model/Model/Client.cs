namespace ControleEstoque.Model.Model;
public class Client : Person
{
    public int ClientID { get; set; }
    public DateTime RegistrationDate { get; private set; }

    public Client(int id, DateTime registration)
    {
        ClientID = id;
        RegistrationDate = registration;
    }

    public Client()
    {
    }

    public override string ToString()
    {
        return $"[{ClientID}, {RegistrationDate}]";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Client other)
        {
            return other.ClientID == ClientID;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return ClientID.GetHashCode();
    }

}

