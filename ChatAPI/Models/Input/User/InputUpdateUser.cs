namespace ChatAPI.Models
{
    public class InputUpdateUser
    {
        public string ServiceSid { get; set; }
        public string UserSid { get; set; }
        public string RoleSid { get; set; }
        public string Attribute { get; set; }
        public string FriendlyName { get; set; }
    }
}