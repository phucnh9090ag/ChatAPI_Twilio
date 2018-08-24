using System;

namespace ChatAPI.Models
{
    public class InputUpdateMessage
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }
        public string messageSid { get; set; }

        //Optional
        public string body { get; set; }
        public string from { get; set; }
        public string attribute { get; set; }
        public DateTime dateCreate { get; set; }
        public DateTime dateUpdate { get; set; }
        public string lastUpdateBy { get; set; }
        public string mediaSid { get; set; }
    }
}