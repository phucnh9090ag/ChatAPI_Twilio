using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V1;

namespace ChatAPI.Models
{
    public class ServiceServices:IServiceServices
    {
        public ServiceServices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object GetAllService()
        {
            var services = ServiceResource.Read();

            return services;
        }

        public object CreateService(InputCreateService input)
        {
            var friendlyName = input.friendlyName;

            var service = ServiceResource.Create(
                friendlyName: friendlyName
            );

            return service;
        }

        public object UpdateService(InputUpdateService input)
        {
            var friendlyName = input.friendlyName;
            var serviceSid = input.serviceSid;

            var service = ServiceResource.Update(
                friendlyName: friendlyName,
                pathSid: serviceSid
            );

            return service;
        }

        public object DeleteService(InputDeleteService input)
        {
            var serviceSid = input.serviceSid;

            var result = ServiceResource.Delete(pathSid: serviceSid);

            return result;
        }
    }
}