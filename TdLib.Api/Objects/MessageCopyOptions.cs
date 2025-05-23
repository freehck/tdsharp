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
        /// Options to be used when a message content is copied without reference to the original sender. Service messages, messages with messageInvoice, messagePaidMedia, messageGiveaway, or messageGiveawayWinners content can't be copied
        /// </summary>
        public partial class MessageCopyOptions : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageCopyOptions";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if content of the message needs to be copied without reference to the original sender. Always true if the message is forwarded to a secret chat or is local.
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("send_copy")]
            public bool SendCopy { get; set; }

            /// <summary>
            /// True, if media caption of the message copy needs to be replaced. Ignored if send_copy is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("replace_caption")]
            public bool ReplaceCaption { get; set; }

            /// <summary>
            /// New message caption; pass null to copy message without caption. Ignored if replace_caption is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_caption")]
            public FormattedText NewCaption { get; set; }

            /// <summary>
            /// True, if new caption must be shown above the media; otherwise, new caption must be shown below the media; not supported in secret chats. Ignored if replace_caption is false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_show_caption_above_media")]
            public bool NewShowCaptionAboveMedia { get; set; }
        }
    }
}
// REUSE-IgnoreEnd