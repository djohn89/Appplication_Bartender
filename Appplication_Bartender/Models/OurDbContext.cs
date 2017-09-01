using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Appplication_Bartender.Models
{
   
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }

        public System.Data.Entity.DbSet<Appplication_Bartender.Models.Customer> Customers { get; set; }
    }
    public class DrinkInfoDBContext : DbContext
    {
        public DbSet<DrinkInfo> drinks { get; set; }
    }
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> customer { get; set; }
    }
}