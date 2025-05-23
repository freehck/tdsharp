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
        public partial class UpgradedGiftAttributeId : Object
        {
            /// <summary>
            /// Identifier of a gift backdrop
            /// </summary>
            public class UpgradedGiftAttributeIdBackdrop : UpgradedGiftAttributeId
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "upgradedGiftAttributeIdBackdrop";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the backdrop
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("backdrop_id")]
                public int BackdropId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd