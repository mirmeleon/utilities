using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryAndUnitExample.Models;

namespace RepositoryAndUnitExample.Interfaces
{
   public interface IUnitOfWork : IDisposable
   {
        IRepository<User> Users { get; }
        void Commit();
   }
}
