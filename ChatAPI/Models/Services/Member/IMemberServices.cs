using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IMemberServices
    {
        object GetAllMember(InputGetAllMember input);
        object AddMember(InputAddMember input);
        object RemoveMember(InputRemoveMember input);

    }
}
