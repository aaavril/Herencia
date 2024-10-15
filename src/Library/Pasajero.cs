using System.Collections;
using System.Dynamic;

namespace Library;

public class Pasajero : User
{
    public int Calificacion {get;set;}
    public Pasajero(string name, string surname, string cedula, int calificacion) : base(name, surname, cedula)
    {
        this.Calificacion = calificacion;
        this.Name = name;
        this.Surname = surname;
        this.Cedula = cedula;

    }

}