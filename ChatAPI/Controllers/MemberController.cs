using ChatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class MemberController : ApiController
    {
        private IMemberServices _memberServices;

        public MemberController()
        {
            _memberServices = new MemberServices();
        }

        [Route("api/Member")]
        [HttpGet]
        public IHttpActionResult GetListAll([FromUri]InputGetAllMember input)
        {
            var result = _memberServices.GetAllMember(input);
            return Ok(result);
        }

        [Route("api/Member")]
        [HttpPost]
        public IHttpActionResult AddMember([FromBody]InputAddMember input)
        {
            var result = _memberServices.AddMember(input);
            return Ok(result);
        }

        [Route("api/Member")]
        [HttpDelete]
        public IHttpActionResult RemoveMember([FromBody]InputRemoveMember input)
        {
            var result = _memberServices.RemoveMember(input);
            return Ok(result);
        }
    }
}
