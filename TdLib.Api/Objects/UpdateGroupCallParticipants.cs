using System;
using Newtonsoft.Json;

// REUSE-IgnoreStart
namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// The list of group call participants that can send and receive encrypted call data has changed; for group calls not bound to a chat only
            /// </summary>
            public class UpdateGroupCallParticipants : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateGroupCallParticipants";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the group call
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("group_call_id")]
                public int GroupCallId { get; set; }

                /// <summary>
                /// New list of group call participant user identifiers. The identifiers may be invalid or the corresponding users may be unknown.
                /// The participants must be shown in the list of group call participants even there is no information about them
                /// </summary>
                [JsonProperty("participant_user_ids", ItemConverterType = typeof(Converter))]
                public long[] ParticipantUserIds { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd