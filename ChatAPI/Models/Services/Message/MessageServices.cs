using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V2.Service.Channel;


namespace ChatAPI.Models
{
    public class MessageServices:IMessageServices
    {
        public MessageServices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object GetListAll(InputGetAllMessage input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;

            var messages = MessageResource.Read(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid
            );

            return messages;
        }

        public object SendMessage(InputSendMessage input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var body = input.Body;
            var from = input.From;
            var attribute = input.Attribute;
            var lastUpdateBy = input.LastUpdateBy;
            var mediaSid = input.MediaSid;

            var message = MessageResource.Create(
                body: body,
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                from: from,
                attributes: attribute,
                lastUpdatedBy: lastUpdateBy,
                mediaSid: mediaSid
            );

            return message;
        }

        public object UpdateMessage(InputUpdateMessage input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var messageSid = input.MessageSid;
            var body = input.Body;
            var attribute = input.Attribute;
            var dateCreate = input.DateCreate;
            var dateUpdate = input.DateUpdate;
            var lasttUpdateBy = input.LastUpdateBy;
            var from = input.From;

            var message = MessageResource.Update(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: messageSid,
                body: body,
                attributes: attribute,
                dateCreated: dateCreate,
                dateUpdated: dateUpdate,
                lastUpdatedBy: lasttUpdateBy,
                from: from
            );

            return message;
        }

        public object DeleteMessage(InputDeleteMessage input)
        {
            var serviceSid = input.ServiceSid;
            var channelSid = input.ChannelSid;
            var messageSid = input.MessageSid;

            var result = MessageResource.Delete(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: messageSid
            );

            return result;
        }
    }
}