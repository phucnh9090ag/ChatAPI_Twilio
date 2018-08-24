using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V1.Service;

namespace ChatAPI.Models
{
    public class RoleServices:IRoleServices
    {
        public RoleServices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object GetAllRole(InputGetAllRole input)
        {
            var serviceSid = input.serviceSid;

            var roles = RoleResource.Read(
                pathServiceSid: serviceSid
            );

            return roles;
        }

        public object CreateRole(InputCreateRole input)
        {
            var serviceSid = input.serviceSid;
            var permission = input.permission;
            var friendlyName = input.friendlyName;

            var role = RoleResource.Create(
                friendlyName: friendlyName,
                type: RoleResource.RoleTypeEnum.Deployment,
                permission: permission,
                pathServiceSid: serviceSid
            );

            return role;
        }

        public object UpdateRole(InputUpdateRole input)
        {
            var serviceSid = input.serviceSid;
            var roleSid = input.roleSid;
            var permission = input.permission;

            var role = RoleResource.Update(
                permission: permission,
                pathServiceSid: serviceSid,
                pathSid: roleSid
            );

            return role;
        }

        public object DeleteRole(InputDeleteRole input)
        {
            var serviceSid = input.serviceSid;
            var roleSid = input.roleSid;

            var result = RoleResource.Delete(
                pathServiceSid: serviceSid,
                pathSid: roleSid
            );

            return result;
        }


    }
}