using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IUserServices
    {
        object GetAllUser(InputGetAllUser input);
        object CreateUser(InputCreateUser input);
        object UpdateUser(InputUpdateUser input);
        object DeleteUser(InputDeleteUser input);
    }
}
