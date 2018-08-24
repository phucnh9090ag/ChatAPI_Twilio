namespace ChatAPI.Models
{
    public class InputUpdateUser
    {
        public string serviceSid { get; set; }
        public string userSid { get; set; }
        public string roleSid { get; set; }
        public string attribute { get; set; }
        public string friendlyName { get; set; }
    }
}