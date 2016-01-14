using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface IDal : IDisposable
    {
    List<User> getAllUsers();
    }

