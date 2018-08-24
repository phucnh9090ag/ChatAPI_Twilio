namespace ChatAPI.Models
{
    public class InputUpdateChannel
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }

        //Optional
        public string friendlyName { get; set; }
        public string uniqueName { get; set; }
        public string attributes { get; set; }
    }
}