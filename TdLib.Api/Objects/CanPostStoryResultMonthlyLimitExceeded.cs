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
        public partial class CanPostStoryResult : Object
        {
            /// <summary>
            /// The monthly limit for the number of posted stories exceeded. The user needs to buy Telegram Premium or wait specified time
            /// </summary>
            public class CanPostStoryResultMonthlyLimitExceeded : CanPostStoryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "canPostStoryResultMonthlyLimitExceeded";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Time left before the user can post the next story
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("retry_after")]
                public int RetryAfter { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd