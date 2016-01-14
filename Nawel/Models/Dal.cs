using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Dal : IDal
{
    private BddContext bdd;

    public Dal()
    {
        bdd = new BddContext();
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
