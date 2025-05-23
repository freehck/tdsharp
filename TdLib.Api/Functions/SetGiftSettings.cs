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
        /// Changes settings for gift receiving for the current user
        /// </summary>
        public class SetGiftSettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setGiftSettings";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new settings
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("settings")]
            public GiftSettings Settings { get; set; }
        }

        /// <summary>
        /// Changes settings for gift receiving for the current user
        /// </summary>
        public static Task<Ok> SetGiftSettingsAsync(
            this Client client, GiftSettings settings = default)
        {
            return client.ExecuteAsync(new SetGiftSettings
            {
                Settings = settings
            });
        }
    }
}
// REUSE-IgnoreEnd