using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Kandidattest.Models;

namespace Kandidattest.Models
{
    public class DbInit : DropCreateDatabaseAlways<DB>
    {
        protected override void Seed(DB context)
        {


            List<User> UserList = new List<User>
                    {
                        new User
                        {
                            Navn = "test test",
                            Kjønn ="Mann",
                            Alder = 21
                        },
                         new User
                        {
                            Navn = "test test",
                            Kjønn ="Kvinne",
                            Alder = 30
                        },
                          new User
                        {
                            Navn = "test test",
                            Kjønn ="Mann",
                            Alder = 31
                        },
                           new User
                        {
                            Navn = "test test",
                            Kjønn ="Kvinne",
                            Alder = 40
                        },
                            new User
                        {
                            Navn = "test test",
                            Kjønn ="Mann",
                            Alder = 41
                        },
                             new User
                        {
                            Navn = "test test",
                            Kjønn ="Kvinne",
                            Alder = 60
                        }
                    };

            foreach (var user in UserList)
            {
                context.User.Add(user);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}