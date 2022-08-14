using CRUDSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDSample.Persistence
{
    public class CRUDSampleDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}