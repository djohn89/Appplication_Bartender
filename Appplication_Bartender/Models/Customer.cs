using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Appplication_Bartender.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public int CustomerAge { get; set; }
        public string Phone { get; set; }
        public int DrinkID { get; set; }
        public string DrinkType { get; set; }



    }
    


}