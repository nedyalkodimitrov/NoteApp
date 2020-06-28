using System;
using System.Collections.Generic;
using System.Text;
using Data.Model;

using Microsoft.Entity;

namespace Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            :base()
        {
        }

        public DbSet<Note> Note { get; set; }
    }
}
