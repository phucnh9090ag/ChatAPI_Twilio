using System.Collections.Generic;

namespace ChatAPI.Models
{
    public class InputUpdateRole
    {
        public string ServiceSid { get; set; }
        public string RoleSid { get; set; }
        public List<string> Permission { get; set; }
    }
}