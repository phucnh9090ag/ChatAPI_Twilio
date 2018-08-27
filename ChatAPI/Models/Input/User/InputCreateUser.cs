namespace ChatAPI.Models
{
    public class InputCreateUser
    {
        public string ServiceSid { get; set; }
        public string Identity { get; set; }

        //Optional
        public string RoleSid { get; set; }
        public string Attributes { get; set; }
        public string FriendlyName { get; set; }
    }
}