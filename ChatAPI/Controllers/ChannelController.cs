using ChatAPI.Models;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class ChannelController : ApiController
    {
        private readonly IChannelServices _channelServices;

        public ChannelController()
        {
            _channelServices = new ChannelServices();
        }

        [Route("api/Channel")]
        [HttpGet]
        public IHttpActionResult GetListAll([FromUri]InputGetAllChannel input)
        {
            var result = _channelServices.GetAllChannel(input);
            return Ok(result);
        }

        [Route("api/Channel")]
        [HttpPost]
        public IHttpActionResult Create([FromBody]InputCreateChannel input)
        {
            var result = _channelServices.CreateChannel(input);
            return Ok(result);
        }

        [Route("api/Channel")]
        [HttpPut]
        public IHttpActionResult Update([FromBody] InputUpdateChannel input)
        {
            var result = _channelServices.UpdateChannel(input);
            return Ok(result);
        }

        [Route("api/Channel")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]InputDeleteChannel input)
        {
            var result = _channelServices.DeleteChannel(input);
            return Ok(result);
        }
    }
}
