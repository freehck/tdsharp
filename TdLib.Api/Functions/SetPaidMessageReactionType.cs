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
        /// Changes type of paid message reaction of the current user on a message. The message must have paid reaction added by the current user
        /// </summary>
        public class SetPaidMessageReactionType : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setPaidMessageReactionType";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat to which the message belongs
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// New type of the paid reaction
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public PaidReactionType Type { get; set; }
        }

        /// <summary>
        /// Changes type of paid message reaction of the current user on a message. The message must have paid reaction added by the current user
        /// </summary>
        public static Task<Ok> SetPaidMessageReactionTypeAsync(
            this Client client, long chatId = default, long messageId = default, PaidReactionType type = default)
        {
            return client.ExecuteAsync(new SetPaidMessageReactionType
            {
                ChatId = chatId, MessageId = messageId, Type = type
            });
        }
    }
}
// REUSE-IgnoreEnd