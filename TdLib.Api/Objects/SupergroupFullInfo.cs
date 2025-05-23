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
        /// Contains full information about a supergroup or channel
        /// </summary>
        public partial class SupergroupFullInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "supergroupFullInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat photo; may be null if empty or unknown. If non-null, then it is the same photo as in chat.photo
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public ChatPhoto Photo { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }

            /// <summary>
            /// Number of members in the supergroup or channel; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_count")]
            public int MemberCount { get; set; }

            /// <summary>
            /// Number of privileged users in the supergroup or channel; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("administrator_count")]
            public int AdministratorCount { get; set; }

            /// <summary>
            /// Number of restricted users in the supergroup; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("restricted_count")]
            public int RestrictedCount { get; set; }

            /// <summary>
            /// Number of users banned from chat; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("banned_count")]
            public int BannedCount { get; set; }

            /// <summary>
            /// Chat identifier of a discussion group for the channel, or a channel, for which the supergroup is the designated discussion group; 0 if none or unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("linked_chat_id")]
            public long LinkedChatId { get; set; }

            /// <summary>
            /// Delay between consecutive sent messages for non-administrator supergroup members, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("slow_mode_delay")]
            public int SlowModeDelay { get; set; }

            /// <summary>
            /// Time left before next message can be sent in the supergroup, in seconds. An updateSupergroupFullInfo update is not triggered when value of this field changes, but both new and old values are non-zero
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("slow_mode_delay_expires_in")]
            public double? SlowModeDelayExpiresIn { get; set; }

            /// <summary>
            /// True, if paid messages can be enabled in the supergroup chat; for supergroup only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_enable_paid_messages")]
            public bool CanEnablePaidMessages { get; set; }

            /// <summary>
            /// True, if paid reaction can be enabled in the channel chat; for channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_enable_paid_reaction")]
            public bool CanEnablePaidReaction { get; set; }

            /// <summary>
            /// True, if members of the chat can be retrieved via getSupergroupMembers or searchChatMembers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_members")]
            public bool CanGetMembers { get; set; }

            /// <summary>
            /// True, if non-administrators can receive only administrators and bots using getSupergroupMembers or searchChatMembers
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_hidden_members")]
            public bool HasHiddenMembers { get; set; }

            /// <summary>
            /// True, if non-administrators and non-bots can be hidden in responses to getSupergroupMembers and searchChatMembers for non-administrators
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_hide_members")]
            public bool CanHideMembers { get; set; }

            /// <summary>
            /// True, if the supergroup sticker set can be changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_sticker_set")]
            public bool CanSetStickerSet { get; set; }

            /// <summary>
            /// True, if the supergroup location can be changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_location")]
            public bool CanSetLocation { get; set; }

            /// <summary>
            /// True, if the supergroup or channel statistics are available
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_statistics")]
            public bool CanGetStatistics { get; set; }

            /// <summary>
            /// True, if the supergroup or channel revenue statistics are available
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_revenue_statistics")]
            public bool CanGetRevenueStatistics { get; set; }

            /// <summary>
            /// True, if the supergroup or channel Telegram Star revenue statistics are available
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_star_revenue_statistics")]
            public bool CanGetStarRevenueStatistics { get; set; }

            /// <summary>
            /// True, if the user can send a gift to the supergroup or channel using sendGift or transferGift
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_send_gift")]
            public bool CanSendGift { get; set; }

            /// <summary>
            /// True, if aggressive anti-spam checks can be enabled or disabled in the supergroup
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_toggle_aggressive_anti_spam")]
            public bool CanToggleAggressiveAntiSpam { get; set; }

            /// <summary>
            /// True, if new chat members will have access to old messages. In public, discussion, of forum groups and all channels, old messages are always available,
            /// so this option affects only private non-forum supergroups without a linked chat. The value of this field is only available to chat administrators
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_all_history_available")]
            public bool IsAllHistoryAvailable { get; set; }

            /// <summary>
            /// True, if the chat can have sponsored messages. The value of this field is only available to the owner of the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_have_sponsored_messages")]
            public bool CanHaveSponsoredMessages { get; set; }

            /// <summary>
            /// True, if aggressive anti-spam checks are enabled in the supergroup. The value of this field is only available to chat administrators
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_aggressive_anti_spam_enabled")]
            public bool HasAggressiveAntiSpamEnabled { get; set; }

            /// <summary>
            /// True, if paid media can be sent and forwarded to the channel chat; for channels only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_paid_media_allowed")]
            public bool HasPaidMediaAllowed { get; set; }

            /// <summary>
            /// True, if the supergroup or channel has pinned stories
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("has_pinned_stories")]
            public bool HasPinnedStories { get; set; }

            /// <summary>
            /// Number of saved to profile gifts for channels without can_post_messages administrator right, otherwise, the total number of received gifts
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("gift_count")]
            public int GiftCount { get; set; }

            /// <summary>
            /// Number of times the current user boosted the supergroup or channel
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("my_boost_count")]
            public int MyBoostCount { get; set; }

            /// <summary>
            /// Number of times the supergroup must be boosted by a user to ignore slow mode and chat permission restrictions; 0 if unspecified
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("unrestrict_boost_count")]
            public int UnrestrictBoostCount { get; set; }

            /// <summary>
            /// Identifier of the supergroup sticker set that must be shown before user sticker sets; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("sticker_set_id")]
            public long StickerSetId { get; set; }

            /// <summary>
            /// Identifier of the custom emoji sticker set that can be used in the supergroup without Telegram Premium subscription; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("custom_emoji_sticker_set_id")]
            public long CustomEmojiStickerSetId { get; set; }

            /// <summary>
            /// Location to which the supergroup is connected; may be null if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public ChatLocation Location { get; set; }

            /// <summary>
            /// Primary invite link for the chat; may be null. For chat administrators with can_invite_users right only
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public ChatInviteLink InviteLink { get; set; }

            /// <summary>
            /// List of commands of bots in the group
            /// </summary>
            [JsonProperty("bot_commands", ItemConverterType = typeof(Converter))]
            public BotCommands[] BotCommands { get; set; }

            /// <summary>
            /// Information about verification status of the supergroup or the channel provided by a bot; may be null if none or unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("bot_verification")]
            public BotVerification BotVerification { get; set; }

            /// <summary>
            /// Identifier of the basic group from which supergroup was upgraded; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_from_basic_group_id")]
            public long UpgradedFromBasicGroupId { get; set; }

            /// <summary>
            /// Identifier of the last message in the basic group from which supergroup was upgraded; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_from_max_message_id")]
            public long UpgradedFromMaxMessageId { get; set; }
        }
    }
}
// REUSE-IgnoreEnd