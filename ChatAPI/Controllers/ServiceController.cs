using ChatAPI.Models;
using System.Web.Http;

namespace ChatAPI.Controllers
{
    public class ServiceController : ApiController
    {
        IServiceServices _serviceServices;

        public ServiceController()
        {
            _serviceServices = new ServiceServices();
        }

        [Route("api/Service")]
        [HttpGet]
        public IHttpActionResult GetListAll()
        {
            var result = _serviceServices.GetAllService();
            return Ok(result);
        }

        [Route("api/Service")]
        [HttpPost]
        public IHttpActionResult Create([FromBody]InputCreateService input)
        {
            var result = _serviceServices.CreateService(input);
            return Ok(result);
        }

        [Route("api/Service")]
        [HttpPut]
        public IHttpActionResult Update([FromBody]InputUpdateService input)
        {
            var result = _serviceServices.UpdateService(input);
            return Ok(result);
        }

        [Route("api/Service")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]InputDeleteService input)
        {
            var result = _serviceServices.DeleteService(input);
            return Ok(result);
        }
    }
}
