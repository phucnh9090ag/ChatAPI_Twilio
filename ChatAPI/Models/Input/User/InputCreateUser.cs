namespace ChatAPI.Models
{
    public class InputCreateUser
    {
        public string serviceSid { get; set; }
        public string identity { get; set; }

        //Optional
        public string roleSid { get; set; }
        public string attributes { get; set; }
        public string friendlyName { get; set; }
    }
}