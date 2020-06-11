using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_2.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Lab_2.Models.Friend> Friends { get; set; }
    }
}