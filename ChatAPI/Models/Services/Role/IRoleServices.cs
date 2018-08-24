using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IRoleServices
    {
        object GetAllRole(InputGetAllRole input);
        object CreateRole(InputCreateRole input);
        object UpdateRole(InputUpdateRole input);
        object DeleteRole(InputDeleteRole input);
    }
}
