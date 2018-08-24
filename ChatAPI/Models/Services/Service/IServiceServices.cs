using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IServiceServices
    {
        object GetAllService();
        object CreateService(InputCreateService input);
        object UpdateService(InputUpdateService input);
        object DeleteService(InputDeleteService input);

    }
}
