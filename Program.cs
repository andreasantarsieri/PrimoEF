using System;
using System.Linq;
using Santarsieri.Andrea._5H.PrimoEF.Models;

namespace Santarsieri.Andrea._5H.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DatabaseWorld!");
            DBPersone db = new DBPersone();
            foreach(var r in db.Persone)
            {
                Console.WriteLine(r);
            
            }
            var p = db.Persone.Max(luigi => luigi.idPersona);
            Console.WriteLine(p);
            db.Persone.RemoveRange(db.Persone);     
            db.Persone.Add(new Persona{Nome = "luigi",Cognome= "secondo",Email="luigisecond@gmail.com"});
            db.SaveChanges();
        }
    }
}
