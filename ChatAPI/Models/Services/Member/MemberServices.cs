﻿using System.Web.Configuration;
using Twilio;
using Twilio.Rest.Chat.V1.Service.Channel;

namespace ChatAPI.Models
{
    public class MemberServices:IMemberServices
    {
        public MemberServices()
        {
            var accountSid = WebConfigurationManager.AppSettings["accountSid"];
            var authToken = WebConfigurationManager.AppSettings["authToken"];
            TwilioClient.Init(accountSid, authToken);
        }
        public object GetAllMember(InputGetAllMember input)
        {
            var pathChannelSid = input.channelSid;
            var serviceSid = input.serviceSid;

            var members = MemberResource.Read(
                pathServiceSid: serviceSid,
                pathChannelSid: pathChannelSid
            );

            return members;
        }

        public object AddMember(InputAddMember input)
        {
            var serviceSid = input.serviceSid;
            var pathChannelSid = input.channelSid;
            var roleSid = input.roleSid;
            var indentity = input.identity;

            var member = MemberResource.Create(
                identity: indentity,
                pathServiceSid: serviceSid,
                pathChannelSid: pathChannelSid,
                roleSid: roleSid
            );

            return member;
        }

        public object RemoveMember(InputRemoveMember input)
        {
            var serviceSid = input.serviceSid;
            var channelSid = input.channelSid;
            var memberSid = input.memberSid;

            var result = MemberResource.Delete(
                pathServiceSid: serviceSid,
                pathChannelSid: channelSid,
                pathSid: memberSid
            );

            return result;
        }
    }
}