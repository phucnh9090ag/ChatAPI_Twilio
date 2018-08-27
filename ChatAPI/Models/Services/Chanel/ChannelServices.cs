using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V1.Service;

namespace ChatAPI.Models
{
    class ChannelServices:IChannelServices
    {
        public ChannelServices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object CreateChannel(InputCreateChannel input)
        {
            var friendlyName = input.FriendlyName;
            var uniqueName = input.UniqueName;
            var attributes = input.Attributes;
            var serviceSid = input.ServiceSid;

            var channel = ChannelResource.Create(
                pathServiceSid: serviceSid,
                friendlyName: friendlyName,
                uniqueName: uniqueName,
                attributes: attributes
            );

            return channel;
        }

        public object GetAllChannel(InputGetAllChannel input)
        {
            var serviceSid = input.ServiceSid;

            var channels = ChannelResource.Read(
                pathServiceSid: serviceSid
            );

            return channels;
        }

        public object UpdateChannel(InputUpdateChannel input)
        {
            var serviceSid = input.ServiceSid;
            var friendlyName = input.FriendlyName;
            var channelSid = input.ChannelSid;
            var uniqueName = input.UniqueName;
            var attributes = input.Attributes;

            var channel = ChannelResource.Update(
                pathServiceSid: serviceSid,
                pathSid: channelSid,
                friendlyName: friendlyName,
                uniqueName: uniqueName,
                attributes: attributes
            );

            return channel;
        }

        public object DeleteChannel(InputDeleteChannel input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;

            var result = ChannelResource.Delete(
                pathServiceSid: serviceSid,
                pathSid: channelSid
            );

            return result;
        }
    }
}