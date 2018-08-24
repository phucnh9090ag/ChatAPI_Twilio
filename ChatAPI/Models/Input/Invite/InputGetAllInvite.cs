using System.Collections.Generic;

namespace ChatAPI.Models
{
    public class InputGetAllInvite
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }

        //Optional
        public List<string> identity { get; set; }
    }
}