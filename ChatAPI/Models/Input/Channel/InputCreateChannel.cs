namespace ChatAPI.Models
{
    public class InputCreateChannel
    {
        public string ServiceSid { get; set; }

        //Optional
        public string FriendlyName { get; set; }
        public string UniqueName { get; set; }
        public string Attributes { get; set; }
    }
}