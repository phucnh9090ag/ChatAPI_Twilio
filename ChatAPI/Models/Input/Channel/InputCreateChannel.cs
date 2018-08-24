namespace ChatAPI.Models
{
    public class InputCreateChannel
    {
        public string serviceSid { get; set; }

        //Optional
        public string friendlyName { get; set; }
        public string uniqueName { get; set; }
        public string attributes { get; set; }
    }
}