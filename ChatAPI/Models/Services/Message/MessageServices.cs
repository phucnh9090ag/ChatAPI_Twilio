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
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;

            var messages = MessageResource.Read(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid
            );

            return messages;
        }

        public object SendMessage(InputSendMessage input)
        {
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var body = input.body;
            var from = input.from;
            var attribute = input.attribute;
            var lastUpdateBy = input.lastUpdateBy;
            var mediaSid = input.mediaSid;

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
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var messageSid = input.messageSid;
            var body = input.body;
            var attribute = input.attribute;
            var dateCreate = input.dateCreate;
            var dateUpdate = input.dateUpdate;
            var lasttUpdateBy = input.lastUpdateBy;
            var from = input.from;

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
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var messageSid = input.messageSid;

            var result = MessageResource.Delete(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: messageSid
            );

            return result;
        }
    }
}