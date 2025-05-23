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
        /// Changes a profile photo for the current user
        /// </summary>
        public class SetProfilePhoto : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setProfilePhoto";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Profile photo to set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public InputChatPhoto Photo { get; set; }

            /// <summary>
            /// Pass true to set the public photo, which will be visible even the main photo is hidden by privacy settings
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_public")]
            public bool IsPublic { get; set; }
        }

        /// <summary>
        /// Changes a profile photo for the current user
        /// </summary>
        public static Task<Ok> SetProfilePhotoAsync(
            this Client client, InputChatPhoto photo = default, bool isPublic = default)
        {
            return client.ExecuteAsync(new SetProfilePhoto
            {
                Photo = photo, IsPublic = isPublic
            });
        }
    }
}
// REUSE-IgnoreEnd