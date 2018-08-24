using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPI.Models
{
    interface IMessageServices
    {
        object GetListAll(InputGetAllMessage input);
        object SendMessage(InputSendMessage input);
        object UpdateMessage(InputUpdateMessage input);
        object DeleteMessage(InputDeleteMessage input);
    }
}
