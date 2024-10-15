using System.Collections;
using System.Dynamic;

namespace Library;
public abstract class User
{
      public string Name { get; set;}
      public string Surname { get; set;}
      public string Cedula { get; set;}

    public User(string Name, string Surname, string Cedula) 
{
    this.Name = Name;
    this.Surname = Surname;
    this.Cedula = Cedula;
    
}


}
