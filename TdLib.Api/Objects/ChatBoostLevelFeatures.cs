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
        /// Contains a list of features available on a specific chat boost level
        /// </summary>
        public partial class ChatBoostLevelFeatures : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatBoostLevelFeatures";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Target chat boost level
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("level")]
            public int Level { get; set; }

            /// <summary>
            /// Number of stories that the chat can publish daily
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("story_per_day_count")]
            public int StoryPerDayCount { get; set; }

            /// <summary>
            /// Number of custom emoji reactions that can be added to the list of available reactions
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("custom_emoji_reaction_count")]
            public int CustomEmojiReactionCount { get; set; }

            /// <summary>
            /// Number of custom colors for chat title
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title_color_count")]
            public int TitleColorCount { get; set; }

            /// <summary>
            /// Number of custom colors for profile photo background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("profile_accent_color_count")]
            public int ProfileAccentColorCount { get; set; }

            /// <summary>
            /// True, if custom emoji for profile background can be set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_profile_background_custom_emoji")]
            public bool CanSetProfileBackgroundCustomEmoji { get; set; }

            /// <summary>
            /// Number of custom colors for background of empty chat photo, replies to messages and link previews
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("accent_color_count")]
            public int AccentColorCount { get; set; }

            /// <summary>
            /// True, if custom emoji for reply header and link preview background can be set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_background_custom_emoji")]
            public bool CanSetBackgroundCustomEmoji { get; set; }

            /// <summary>
            /// True, if emoji status can be set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_emoji_status")]
            public bool CanSetEmojiStatus { get; set; }

            /// <summary>
            /// Number of chat theme backgrounds that can be set as chat background
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_theme_background_count")]
            public int ChatThemeBackgroundCount { get; set; }

            /// <summary>
            /// True, if custom background can be set in the chat for all users
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_custom_background")]
            public bool CanSetCustomBackground { get; set; }

            /// <summary>
            /// True, if custom emoji sticker set can be set for the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_custom_emoji_sticker_set")]
            public bool CanSetCustomEmojiStickerSet { get; set; }

            /// <summary>
            /// True, if automatic translation of messages can be enabled in the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_enable_automatic_translation")]
            public bool CanEnableAutomaticTranslation { get; set; }

            /// <summary>
            /// True, if speech recognition can be used for video note and voice note messages by all users
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_recognize_speech")]
            public bool CanRecognizeSpeech { get; set; }

            /// <summary>
            /// True, if sponsored messages can be disabled in the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_disable_sponsored_messages")]
            public bool CanDisableSponsoredMessages { get; set; }
        }
    }
}
// REUSE-IgnoreEnd