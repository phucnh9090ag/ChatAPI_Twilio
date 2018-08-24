using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V1.Service;

namespace ChatAPI.Models
{
    public class UserSevices:IUserServices
    {
        public UserSevices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object GetAllUser(InputGetAllUser input)
        {
            var serviceSid = input.serviceSid;

            var users = UserResource.Read(
                pathServiceSid: serviceSid
            );

            return users;
        }

        public object CreateUser(InputCreateUser input)
        {
            var serviceSid = input.serviceSid;
            var identity = input.identity;
            var roleSid = input.roleSid;
            var attribute = input.attributes;
            var friendlyName = input.friendlyName;

            var user = UserResource.Create(
                identity: identity,
                pathServiceSid: serviceSid,
                roleSid: roleSid,
                attributes:attribute,
                friendlyName: friendlyName
            );

            return user;
        }

        public object UpdateUser(InputUpdateUser input)
        {
            var serviceSid = input.serviceSid;
            var roleSid = input.roleSid;
            var userSid = input.userSid;
            var attribute = input.attribute;
            var friendlyName = input.friendlyName;

            var user = UserResource.Update(
                roleSid: roleSid,
                pathServiceSid: serviceSid,
                pathSid: userSid,
                attributes: attribute,
                friendlyName: friendlyName
            );

            return user;
        }

        public object DeleteUser(InputDeleteUser input)
        {
            var serviceSid = input.serviceSid;
            var userSid = input.userSid;

            var result = UserResource.Delete(
                pathServiceSid: serviceSid,
                pathSid: userSid
            );

            return result;
        }
    }
}