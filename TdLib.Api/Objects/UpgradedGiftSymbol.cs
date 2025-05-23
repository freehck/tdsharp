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
        /// Describes a symbol shown on the pattern of an upgraded gift
        /// </summary>
        public partial class UpgradedGiftSymbol : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "upgradedGiftSymbol";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Name of the symbol
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// The sticker representing the symbol
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("sticker")]
            public Sticker Sticker { get; set; }

            /// <summary>
            /// The number of upgraded gifts that receive this symbol for each 1000 gifts upgraded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("rarity_per_mille")]
            public int RarityPerMille { get; set; }
        }
    }
}
// REUSE-IgnoreEnd