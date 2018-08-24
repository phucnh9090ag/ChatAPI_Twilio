namespace ChatAPI.Models
{
    public class InputSendMessage
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }

        //Optional
        public string body { get; set; }
        public string from { get; set; }
        public string attribute { get; set; }
        public string lastUpdateBy { get; set; }
        public string mediaSid { get; set; }
    }
}