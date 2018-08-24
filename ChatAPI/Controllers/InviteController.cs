using ChatAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class InviteController : ApiController
    {
        IInviteServices _inviteServices;
        public InviteController()
        {
            _inviteServices = new InviteServices();
        }

        [Route("api/Invite")]
        [HttpGet]
        public IHttpActionResult GetAllInvite([FromUri]InputGetAllInvite input)
        {
            var result = _inviteServices.GetListAll(input);
            return Ok(result);
        }

        [Route("api/Invite")]
        [HttpPost]
        public IHttpActionResult Create([FromBody]InputCreateInvite input)
        {
            var result = _inviteServices.CreateInvite(input);
            return Ok(result);
        }

        [Route("api/Invite")]
        [HttpGet]
        public IHttpActionResult Read([FromUri]InputReadInvite input)
        {
            var result = _inviteServices.ReadInvite(input);
            return Ok(result);
        }

        [Route("api/Invite")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]InputDeleteInvite input)
        {
            var result = _inviteServices.DeleteInvite(input);
            return Ok(result);
        }
    }
}
