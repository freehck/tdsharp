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
        /// Starts a scheduled video chat
        /// </summary>
        public class StartScheduledVideoChat : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "startScheduledVideoChat";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Group call identifier of the video chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("group_call_id")]
            public int GroupCallId { get; set; }
        }

        /// <summary>
        /// Starts a scheduled video chat
        /// </summary>
        public static Task<Ok> StartScheduledVideoChatAsync(
            this Client client, int groupCallId = default)
        {
            return client.ExecuteAsync(new StartScheduledVideoChat
            {
                GroupCallId = groupCallId
            });
        }
    }
}
// REUSE-IgnoreEnd