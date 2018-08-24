namespace ChatAPI.Models
{
    public class InputRemoveMember
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }
        public string memberSid { get; set; }
    }
}