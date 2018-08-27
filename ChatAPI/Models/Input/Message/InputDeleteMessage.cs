namespace ChatAPI.Models
{
    public class InputDeleteMessage
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }
        public string MessageSid { get; set; }
    }
}