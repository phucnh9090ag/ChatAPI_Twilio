using ChatAPI.Models;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class MessageController : ApiController
    {
        IMessageServices _messageServices;

        public MessageController()
        {
            _messageServices = new MessageServices();
        }

        [Route("api/Message")]
        [HttpGet]
        public IHttpActionResult GetListAll([FromUri]InputGetAllMessage input)
        {
            var result = _messageServices.GetListAll(input);
            return Ok(result);
        }

        [Route("api/Message")]
        [HttpPost]
        public IHttpActionResult Send([FromBody]InputSendMessage input)
        {
            var result = _messageServices.SendMessage(input);
            return Ok(result);
        }

        [Route("api/Message")]
        [HttpPut]
        public IHttpActionResult Update([FromBody]InputUpdateMessage input)
        {
            var result = _messageServices.UpdateMessage(input);
            return Ok(result);
        }

        [Route("api/Message")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]InputDeleteMessage input)
        {
            var result = _messageServices.DeleteMessage(input);
            return Ok(result);
        }

    }
}
