using System;

namespace ChatAPI.Models
{
    public class InputUpdateMessage
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }
        public string MessageSid { get; set; }

        //Optional
        public string Body { get; set; }
        public string From { get; set; }
        public string Attribute { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public string MediaSid { get; set; }
    }
}