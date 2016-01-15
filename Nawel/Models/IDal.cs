using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nawel.Models
{

    interface IDal : IDisposable
    {
        List<User> getAllUsers();
        void createUser(string num, string username);
    }
}