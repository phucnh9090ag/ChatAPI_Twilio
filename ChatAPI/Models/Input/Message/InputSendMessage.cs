namespace ChatAPI.Models
{
    public class InputSendMessage
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }

        //Optional
        public string Body { get; set; }
        public string From { get; set; }
        public string Attribute { get; set; }
        public string LastUpdateBy { get; set; }
        public string MediaSid { get; set; }
    }
}