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
        public partial class LinkPreviewType : Object
        {
            /// <summary>
            /// The link is a link to a story. Link preview description is unavailable
            /// </summary>
            public class LinkPreviewTypeStory : LinkPreviewType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "linkPreviewTypeStory";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The identifier of the chat that posted the story
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("story_poster_chat_id")]
                public long StoryPosterChatId { get; set; }

                /// <summary>
                /// Story identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("story_id")]
                public int StoryId { get; set; }
            }
        }
    }
}
// REUSE-IgnoreEnd