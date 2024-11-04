namespace ControleEstoque.Model.Model;

    public class Person
    {
        public int PersonID { get; set; }
        public string? Name { get; private set; }
        public string? Lastname { get; private set; }
        public string? CPF { get; private set; }
        public string? Cellphone { get; private set; }
        public string? Address { get; private set; }

        public Person(int id, string name, string lastname, string cpf, string cellphone, string address)
        {
            PersonID = id;
            Name = name;
            Lastname = lastname;
            CPF = cpf;
            Cellphone = cellphone;
            Address = address;
        }

        public Person()
        {

        }

        //public string NomeCompleto()
        //{
        //    return $"{this.Name} {this.Lastname}";
        //}


        public override string ToString()
        {
            return $"[{PersonID}, {Lastname}, {CPF}, {Cellphone}, {Address}]";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person other)
            {
                return other.PersonID == PersonID;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return PersonID.GetHashCode();
        }
    }