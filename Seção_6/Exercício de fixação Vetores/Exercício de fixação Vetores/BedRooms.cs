using System.Runtime;

namespace Exercício_de_fixação_Vetores;

public class BedRooms
{
     public string Name { get;  set; }
     public string Email { get;  set; }

     public BedRooms(string name, string email)
     {
      Name = name;
      Email = email;          
     }

     public override string ToString()
     {
         return Name + ", " + Email;
     }

}