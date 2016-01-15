using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nawel.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void createUser(string num, string username)
        {
            bdd.Users.Add(new User { Num = num, Username = username });
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public List<User> getAllUsers()
        {
            return bdd.Users.ToList();
        }
    }
}
