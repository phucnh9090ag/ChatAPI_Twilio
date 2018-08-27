using System.Collections.Generic;

namespace ChatAPI.Models
{
    public class InputGetAllInvite
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }

        //Optional
        public List<string> Identity { get; set; }
    }
}