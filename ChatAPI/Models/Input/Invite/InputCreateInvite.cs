namespace ChatAPI.Models
{
    public class InputCreateInvite
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }
        public string identity { get; set; }

        //Optional
        public string roleSid { get; set; }
    }
}