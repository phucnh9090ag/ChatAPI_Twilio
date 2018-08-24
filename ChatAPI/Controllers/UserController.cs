using ChatAPI.Models;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class UserController : ApiController
    {
        IUserServices _userServices;

        public UserController()
        {
            _userServices = new UserSevices();
        }

        [Route("api/User")]
        [HttpGet]
        public IHttpActionResult GetListAll([FromUri]InputGetAllUser input)
        {
            var result = _userServices.GetAllUser(input);
            return Ok(result);
        }

        [Route("api/User")]
        [HttpPost]
        public IHttpActionResult Create([FromBody]InputCreateUser input)
        {
            var result = _userServices.CreateUser(input);
            return Ok(result);
        }

        [Route("api/User")]
        [HttpPut]
        public IHttpActionResult Update([FromBody]InputUpdateUser input)
        {
            var result = _userServices.UpdateUser(input);
            return Ok(result);
        }

        [Route("api/User")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]InputDeleteUser input)
        {
            var result = _userServices.DeleteUser(input);
            return Ok(result);
        }
    }
}
