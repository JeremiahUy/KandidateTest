using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kandidattest.Models
{


    public class User
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Kjønn { get; set; }
        public int Alder { get; set; }

    }



    public class DB : DbContext
    {
        public DB() : base("name=KandidatTest")
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new DbInit());
        }

        public virtual DbSet<User> User { get; set; }
    
    }
}