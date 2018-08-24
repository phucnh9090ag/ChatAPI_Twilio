using System.Collections.Generic;

namespace ChatAPI.Models
{
    public class InputCreateRole
    {
        public string serviceSid { get; set; }
        public string friendlyName { get; set; }
        public List<string> permission { get; set; }
    }
}