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
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var identity = input.identity;

            var invites = InviteResource.Read(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                identity: identity
            );

            return invites;
        }

        public object CreateInvite(InputCreateInvite input)
        {
            var identity = input.identity;
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var roleSid = input.roleSid;

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
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var inviteSid = input.inviteSid;

            var invite = InviteResource.Fetch(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: inviteSid
            );

            return invite;
        }

        public object DeleteInvite(InputDeleteInvite input)
        {
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var inviteSid = input.inviteSid;

            var result = InviteResource.Delete(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: inviteSid
            );

            return result;
        }
    }
}