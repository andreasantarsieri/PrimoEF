using System.ComponentModel.DataAnnotations;
namespace Santarsieri.Andrea._5H.PrimoEF.Models

{
    public class Persona
    {
        [Key]
        public int idPersona {get;set;}
        public string Nome {get;set;}
        public string Cognome {get;set;}
        [EmailAddress]
        public string Email {get;set;}

        public override string ToString()
        {
            return $"{idPersona}\t{Nome}\t\t{Cognome}\t{Email}";
        }
    }
}