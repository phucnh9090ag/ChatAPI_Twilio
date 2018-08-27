namespace ChatAPI.Models
{
    public class InputAddMember
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }
        public string Identity { get; set; }

        //Optional
        public string RoleSid { get; set; }
    }
}