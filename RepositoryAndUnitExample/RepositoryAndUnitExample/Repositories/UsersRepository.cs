using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryAndUnitExample.Models;

namespace RepositoryAndUnitExample.Repositories
{
  public class UsersRepository :Repository<User>
    {
        public UsersRepository(DbContext context) : base(context)
        {
        }
    }
}
