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
        /// Represents a list of video chat streams
        /// </summary>
        public partial class VideoChatStreams : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "videoChatStreams";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// A list of video chat streams
            /// </summary>
            [JsonProperty("streams", ItemConverterType = typeof(Converter))]
            public VideoChatStream[] Streams { get; set; }
        }
    }
}
// REUSE-IgnoreEnd