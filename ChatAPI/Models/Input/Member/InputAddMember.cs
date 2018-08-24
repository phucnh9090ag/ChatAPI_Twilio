namespace ChatAPI.Models
{
    public class InputAddMember
    {
        public string serviceSid { get; set; }
        public string channelSid { get; set; }
        public string identity { get; set; }

        //Optional
        public string roleSid { get; set; }
    }
}