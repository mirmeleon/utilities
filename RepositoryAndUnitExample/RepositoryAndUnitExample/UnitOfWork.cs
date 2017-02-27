using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryAndUnitExample.Interfaces;
using RepositoryAndUnitExample.Models;
using RepositoryAndUnitExample.Repositories;

namespace RepositoryAndUnitExample
{
  public class UnitOfWork : IUnitOfWork
  {
      private readonly MyContext context;

      public UnitOfWork(MyContext context)
      {
          this.context = context;
          this.Users = new UsersRepository(context);
      }
       

        public IRepository<User> Users { get; private set; }
        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
