using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryAndUnitExample.Interfaces;
using RepositoryAndUnitExample.Models;

namespace RepositoryAndUnitExample
{
    class StartUp
    {
        static void Main()
        {
            IUnitOfWork uw = new UnitOfWork(new MyContext());
            User user = new User() {UserName = "deni", Password = "2223"};
            uw.Users.Add(user);
            uw.Commit();
        }
    }
}
