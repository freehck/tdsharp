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
        /// Invites a user to an active group call; for group calls not bound to a chat only. Sends a service message of the type messageGroupCall.
        /// The group call can have at most getOption("group_call_participant_count_max") participants
        /// </summary>
        public class InviteGroupCallParticipant : Function<InviteGroupCallParticipantResult>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inviteGroupCallParticipant";

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
            /// User identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public long UserId { get; set; }

            /// <summary>
            /// Pass true if the group call is a video call
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_video")]
            public bool IsVideo { get; set; }
        }

        /// <summary>
        /// Invites a user to an active group call; for group calls not bound to a chat only. Sends a service message of the type messageGroupCall.
        /// The group call can have at most getOption("group_call_participant_count_max") participants
        /// </summary>
        public static Task<InviteGroupCallParticipantResult> InviteGroupCallParticipantAsync(
            this Client client, int groupCallId = default, long userId = default, bool isVideo = default)
        {
            return client.ExecuteAsync(new InviteGroupCallParticipant
            {
                GroupCallId = groupCallId, UserId = userId, IsVideo = isVideo
            });
        }
    }
}
// REUSE-IgnoreEnd