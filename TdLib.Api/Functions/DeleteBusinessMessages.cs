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
        /// Deletes messages on behalf of a business account; for bots only
        /// </summary>
        public class DeleteBusinessMessages : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteBusinessMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of business connection through which the messages were received
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("business_connection_id")]
            public string BusinessConnectionId { get; set; }

            /// <summary>
            /// Identifier of the messages
            /// </summary>
            [JsonProperty("message_ids", ItemConverterType = typeof(Converter))]
            public long[] MessageIds { get; set; }
        }

        /// <summary>
        /// Deletes messages on behalf of a business account; for bots only
        /// </summary>
        public static Task<Ok> DeleteBusinessMessagesAsync(
            this Client client, string businessConnectionId = default, long[] messageIds = default)
        {
            return client.ExecuteAsync(new DeleteBusinessMessages
            {
                BusinessConnectionId = businessConnectionId, MessageIds = messageIds
            });
        }
    }
}
// REUSE-IgnoreEnd