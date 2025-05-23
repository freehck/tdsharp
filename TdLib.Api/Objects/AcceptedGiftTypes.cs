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
        /// Describes gift types that are accepted by a user
        /// </summary>
        public partial class AcceptedGiftTypes : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "acceptedGiftTypes";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if unlimited regular gifts are accepted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("unlimited_gifts")]
            public bool UnlimitedGifts { get; set; }

            /// <summary>
            /// True, if limited regular gifts are accepted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limited_gifts")]
            public bool LimitedGifts { get; set; }

            /// <summary>
            /// True, if upgraded gifts and regular gifts that can be upgraded for free are accepted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_gifts")]
            public bool UpgradedGifts { get; set; }

            /// <summary>
            /// True, if Telegram Premium subscription is accepted
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("premium_subscription")]
            public bool PremiumSubscription { get; set; }
        }
    }
}
// REUSE-IgnoreEnd