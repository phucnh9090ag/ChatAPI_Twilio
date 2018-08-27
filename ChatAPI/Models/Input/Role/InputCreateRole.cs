using System.Collections.Generic;

namespace ChatAPI.Models
{
    public class InputCreateRole
    {
        public string ServiceSid { get; set; }
        public string FriendlyName { get; set; }
        public string Type; //Deployment or Channel
        public List<string> Permission { get; set; }
    }
}