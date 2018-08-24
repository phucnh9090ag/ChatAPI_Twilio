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
            var friendlyName = input.friendlyName;
            var uniqueName = input.uniqueName;
            var attributes = input.attributes;
            var serviceSid = input.serviceSid;

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
            var serviceSid = input.serviceSid;

            var channels = ChannelResource.Read(
                pathServiceSid: serviceSid
            );

            return channels;
        }

        public object UpdateChannel(InputUpdateChannel input)
        {
            var serviceSid = input.serviceSid;
            var friendlyName = input.friendlyName;
            var channelSid = input.channelSid;
            var uniqueName = input.uniqueName;
            var attributes = input.attributes;

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
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;

            var result = ChannelResource.Delete(
                pathServiceSid: serviceSid,
                pathSid: channelSid
            );

            return result;
        }
    }
}