using ChatAPI.Models;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class RoleController : ApiController
    {
        private readonly IRoleServices _roleServices;

        public RoleController()
        {
            _roleServices = new RoleServices();
        }

        [Route("api/Role")]
        [HttpGet]
        public IHttpActionResult GetListAll([FromUri]InputGetAllRole input)
        {
            var result = _roleServices.GetAllRole(input);
            return Ok(result);
        }

        [Route("api/Role")]
        [HttpPost]
        public IHttpActionResult Create([FromBody]InputCreateRole input)
        {
            var result = _roleServices.CreateRole(input);
            return Ok(result);
        }

        [Route("api/Role")]
        [HttpPut]
        public IHttpActionResult Update([FromBody]InputUpdateRole input)
        {
            var result = _roleServices.UpdateRole(input);
            return Ok(result);
        }

        [Route("api/Role")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]InputDeleteRole input)
        {
            var result = _roleServices.DeleteRole(input);
            return Ok(result);
        }
    }
}
