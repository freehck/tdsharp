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
        /// <summary>
        /// Contains settings for gift receiving for a user
        /// </summary>
        public partial class GiftSettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "giftSettings";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if a button for sending a gift to the user or by the user must always be shown in the input field
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("show_gift_button")]
            public bool ShowGiftButton { get; set; }

            /// <summary>
            /// Types of gifts accepted by the user; for Telegram Premium users only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("accepted_gift_types")]
            public AcceptedGiftTypes AcceptedGiftTypes { get; set; }
        }
    }
}
// REUSE-IgnoreEnd