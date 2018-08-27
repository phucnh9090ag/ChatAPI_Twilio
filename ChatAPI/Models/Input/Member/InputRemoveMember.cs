namespace ChatAPI.Models
{
    public class InputRemoveMember
    {
        public string ServiceSid { get; set; }
        public string ChannelSid { get; set; }
        public string MemberSid { get; set; }
    }
}