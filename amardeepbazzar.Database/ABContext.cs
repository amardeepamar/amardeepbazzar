using amardeepbazzar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amardeepbazzar.Database
{
    public class ABContext : DbContext,IDisposable
    {
        public ABContext() : base("AmardeepBazzarConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
