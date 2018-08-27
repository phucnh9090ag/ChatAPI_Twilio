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
            var serviceSid = input.ServiceSid;

            var roles = RoleResource.Read(
                pathServiceSid: serviceSid
            );

            return roles;
        }

        public object CreateRole(InputCreateRole input)
        {
            var serviceSid = input.ServiceSid;
            var permission = input.Permission;
            var friendlyName = input.FriendlyName;
            RoleResource.RoleTypeEnum type;
            if (input.Type == TypeRole.Channel.ToString())
                type = RoleResource.RoleTypeEnum.Channel;
            else 
                type = RoleResource.RoleTypeEnum.Deployment;

            var role = RoleResource.Create(
                friendlyName: friendlyName,
                type: type,
                permission: permission,
                pathServiceSid: serviceSid
            );

            return role;
        }

        public object UpdateRole(InputUpdateRole input)
        {
            var serviceSid = input.ServiceSid;
            var roleSid = input.RoleSid;
            var permission = input.Permission;

            var role = RoleResource.Update(
                permission: permission,
                pathServiceSid: serviceSid,
                pathSid: roleSid
            );

            return role;
        }

        public object DeleteRole(InputDeleteRole input)
        {
            var serviceSid = input.ServiceSid;
            var roleSid = input.RoleSid;

            var result = RoleResource.Delete(
                pathServiceSid: serviceSid,
                pathSid: roleSid
            );

            return result;
        }


    }
}