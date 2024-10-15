using System.Collections;
using System.Dynamic;

namespace Library;

public class Conductor : User
{
    public string Vehiculo{get;set;}
    public Conductor(string name, string surname, string cedula, string vehiculo) : base(name, surname, cedula)
    {
        this.Vehiculo = vehiculo;
        this.Name = name;
        this.Surname = surname;
        this.Cedula = cedula;

    }

}