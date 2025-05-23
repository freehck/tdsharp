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
        /// Returns gifts received by the given user or chat
        /// </summary>
        public class GetReceivedGifts : Function<ReceivedGifts>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getReceivedGifts";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier of business connection on behalf of which to send the request; for bots only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("business_connection_id")]
            public string BusinessConnectionId { get; set; }

            /// <summary>
            /// Identifier of the gift receiver
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("owner_id")]
            public MessageSender OwnerId { get; set; }

            /// <summary>
            /// Pass true to exclude gifts that aren't saved to the chat's profile page. Always true for gifts received by other users and channel chats without can_post_messages administrator right
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_unsaved")]
            public bool ExcludeUnsaved { get; set; }

            /// <summary>
            /// Pass true to exclude gifts that are saved to the chat's profile page. Always false for gifts received by other users and channel chats without can_post_messages administrator right
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_saved")]
            public bool ExcludeSaved { get; set; }

            /// <summary>
            /// Pass true to exclude gifts that can be purchased unlimited number of times
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_unlimited")]
            public bool ExcludeUnlimited { get; set; }

            /// <summary>
            /// Pass true to exclude gifts that can be purchased limited number of times
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_limited")]
            public bool ExcludeLimited { get; set; }

            /// <summary>
            /// Pass true to exclude upgraded gifts
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("exclude_upgraded")]
            public bool ExcludeUpgraded { get; set; }

            /// <summary>
            /// Pass true to sort results by gift price instead of send date
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sort_by_price")]
            public bool SortByPrice { get; set; }

            /// <summary>
            /// Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("offset")]
            public string Offset { get; set; }

            /// <summary>
            /// The maximum number of gifts to be returned; must be positive and can't be greater than 100. For optimal performance, the number of returned objects is chosen by TDLib and can be smaller than the specified limit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }
        }

        /// <summary>
        /// Returns gifts received by the given user or chat
        /// </summary>
        public static Task<ReceivedGifts> GetReceivedGiftsAsync(
            this Client client, string businessConnectionId = default, MessageSender ownerId = default, bool excludeUnsaved = default, bool excludeSaved = default, bool excludeUnlimited = default, bool excludeLimited = default, bool excludeUpgraded = default, bool sortByPrice = default, string offset = default, int limit = default)
        {
            return client.ExecuteAsync(new GetReceivedGifts
            {
                BusinessConnectionId = businessConnectionId, OwnerId = ownerId, ExcludeUnsaved = excludeUnsaved, ExcludeSaved = excludeSaved, ExcludeUnlimited = excludeUnlimited, ExcludeLimited = excludeLimited, ExcludeUpgraded = excludeUpgraded, SortByPrice = sortByPrice, Offset = offset, Limit = limit
            });
        }
    }
}
// REUSE-IgnoreEnd