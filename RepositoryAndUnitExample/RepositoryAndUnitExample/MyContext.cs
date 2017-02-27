using RepositoryAndUnitExample.Models;

namespace RepositoryAndUnitExample
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MyContext : DbContext
    {
        
        public MyContext()
            : base("MyContext")
        {
        }

      
        public virtual DbSet<User> Users { get; set; }
    }

    
}