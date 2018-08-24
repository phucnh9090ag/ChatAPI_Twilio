using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IInviteServices
    {
        object GetListAll(InputGetAllInvite input);
        object CreateInvite(InputCreateInvite input);
        object ReadInvite(InputReadInvite input);
        object DeleteInvite(InputDeleteInvite input);

    }
}
