using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V1.Service.Channel;

namespace ChatAPI.Models
{
    public class InviteServices:IInviteServices
    {
        public InviteServices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object GetListAll(InputGetAllInvite input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var identity = input.Identity;

            var invites = InviteResource.Read(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                identity: identity
            );

            return invites;
        }

        public object CreateInvite(InputCreateInvite input)
        {
            var identity = input.Identity;
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var roleSid = input.RoleSid;

            var invite = InviteResource.Create(
                identity: identity,
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                roleSid: roleSid
            );

            return invite;
        }

        public object ReadInvite(InputReadInvite input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var inviteSid = input.InviteSid;

            var invite = InviteResource.Fetch(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: inviteSid
            );

            return invite;
        }

        public object DeleteInvite(InputDeleteInvite input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var inviteSid = input.InviteSid;

            var result = InviteResource.Delete(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: inviteSid
            );

            return result;
        }
    }
}