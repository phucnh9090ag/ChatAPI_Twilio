namespace ChatAPI.Models
{
    public class InputUpdateChannel
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }

        //Optional
        public string FriendlyName { get; set; }
        public string UniqueName { get; set; }
        public string Attributes { get; set; }
    }
}