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
        /// Describes a forum topic
        /// </summary>
        public partial class ForumTopic : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "forumTopic";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Basic information about the topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("info")]
            public ForumTopicInfo Info { get; set; }

            /// <summary>
            /// Last message in the topic; may be null if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_message")]
            public Message LastMessage { get; set; }

            /// <summary>
            /// A parameter used to determine order of the topic in the topic list. Topics must be sorted by the order in descending order
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("order")]
            public long Order { get; set; }

            /// <summary>
            /// True, if the topic is pinned in the topic list
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_pinned")]
            public bool IsPinned { get; set; }

            /// <summary>
            /// Number of unread messages in the topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("unread_count")]
            public int UnreadCount { get; set; }

            /// <summary>
            /// Identifier of the last read incoming message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_read_inbox_message_id")]
            public long LastReadInboxMessageId { get; set; }

            /// <summary>
            /// Identifier of the last read outgoing message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_read_outbox_message_id")]
            public long LastReadOutboxMessageId { get; set; }

            /// <summary>
            /// Number of unread messages with a mention/reply in the topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("unread_mention_count")]
            public int UnreadMentionCount { get; set; }

            /// <summary>
            /// Number of messages with unread reactions in the topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("unread_reaction_count")]
            public int UnreadReactionCount { get; set; }

            /// <summary>
            /// Notification settings for the topic
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("notification_settings")]
            public ChatNotificationSettings NotificationSettings { get; set; }

            /// <summary>
            /// A draft of a message in the topic; may be null if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("draft_message")]
            public DraftMessage DraftMessage { get; set; }
        }
    }
}
// REUSE-IgnoreEnd