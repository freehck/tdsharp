using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Joins an active video chat. Returns join response payload for tgcalls
        /// </summary>
        public class JoinVideoChat : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "joinVideoChat";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }

            /// <summary>
            /// Identifier of a group call participant, which will be used to join the call; pass null to join as self; video chats only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("participant_id")]
            public MessageSender ParticipantId { get; set; }

            /// <summary>
            /// Parameters to join the call
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("join_parameters")]
            public GroupCallJoinParameters JoinParameters { get; set; }

            /// <summary>
            /// Invite hash as received from internalLinkTypeVideoChat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_hash")]
            public string InviteHash { get; set; }
        }

        /// <summary>
        /// Joins an active video chat. Returns join response payload for tgcalls
        /// </summary>
        public static Task<Text> JoinVideoChatAsync(
            this Client client, int groupCallId = default, MessageSender participantId = default, GroupCallJoinParameters joinParameters = default, string inviteHash = default)
        {
            return client.ExecuteAsync(new JoinVideoChat
            {
                GroupCallId = groupCallId, ParticipantId = participantId, JoinParameters = joinParameters, InviteHash = inviteHash
            });
        }
    }
}
// REUSE-IgnoreEnd