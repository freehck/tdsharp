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
        /// Declines an invitation to an active group call via messageGroupCall. Can be called both by the sender and the receiver of the invitation
        /// </summary>
        public class DeclineGroupCallInvitation : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "declineGroupCallInvitation";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat with the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message of the type messageGroupCall
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }
        }

        /// <summary>
        /// Declines an invitation to an active group call via messageGroupCall. Can be called both by the sender and the receiver of the invitation
        /// </summary>
        public static Task<Ok> DeclineGroupCallInvitationAsync(
            this Client client, long chatId = default, long messageId = default)
        {
            return client.ExecuteAsync(new DeclineGroupCallInvitation
            {
                ChatId = chatId, MessageId = messageId
            });
        }
    }
}
// REUSE-IgnoreEnd