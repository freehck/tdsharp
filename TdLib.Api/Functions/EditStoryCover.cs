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
        /// Changes cover of a video story. Can be called only if story.can_be_edited == true and the story isn't being edited now
        /// </summary>
        public class EditStoryCover : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editStoryCover";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat that posted the story
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("story_poster_chat_id")]
            public long StoryPosterChatId { get; set; }

            /// <summary>
            /// Identifier of the story to edit
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("story_id")]
            public int StoryId { get; set; }

            /// <summary>
            /// New timestamp of the frame, which will be used as video thumbnail
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("cover_frame_timestamp")]
            public double? CoverFrameTimestamp { get; set; }
        }

        /// <summary>
        /// Changes cover of a video story. Can be called only if story.can_be_edited == true and the story isn't being edited now
        /// </summary>
        public static Task<Ok> EditStoryCoverAsync(
            this Client client, long storyPosterChatId = default, int storyId = default, double? coverFrameTimestamp = default)
        {
            return client.ExecuteAsync(new EditStoryCover
            {
                StoryPosterChatId = storyPosterChatId, StoryId = storyId, CoverFrameTimestamp = coverFrameTimestamp
            });
        }
    }
}
// REUSE-IgnoreEnd