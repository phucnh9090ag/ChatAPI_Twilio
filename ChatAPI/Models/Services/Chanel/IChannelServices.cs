using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IChannelServices
    {
        object CreateChannel(InputCreateChannel input);
        object GetAllChannel(InputGetAllChannel input);
        object UpdateChannel(InputUpdateChannel input);
        object DeleteChannel(InputDeleteChannel input);

    }
}
