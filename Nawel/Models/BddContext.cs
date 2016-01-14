using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


public class BddContext : DbContext
    {
     public DbSet<User> Users { get; set; }
    }
