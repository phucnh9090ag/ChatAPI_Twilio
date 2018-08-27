namespace ChatAPI.Models
{
    public class InputCreateInvite
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }
        public string Identity { get; set; }

        //Optional
        public string RoleSid { get; set; }
    }
}