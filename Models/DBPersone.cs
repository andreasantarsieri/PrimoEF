using System;
using Microsoft.EntityFrameworkCore;
namespace Santarsieri.Andrea._5H.PrimoEF.Models
{
    public class DBPersone: DbContext

    {   
        public DbSet<Persona> Persone {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source = DbPersone.db");
        }
    }


}
