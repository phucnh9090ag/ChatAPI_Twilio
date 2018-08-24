namespace ChatAPI.Models
{
    public class InputDeleteMessage
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }
        public string messageSid { get; set; }
    }
}