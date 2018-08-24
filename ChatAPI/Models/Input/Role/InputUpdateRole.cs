using System.Collections.Generic;

namespace ChatAPI.Models
{
    public class InputUpdateRole
    {
        public string serviceSid { get; set; }
        public string roleSid { get; set; }
        public List<string> permission { get; set; }
    }
}