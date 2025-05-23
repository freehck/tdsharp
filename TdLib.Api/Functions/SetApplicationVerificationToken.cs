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
        /// Application or reCAPTCHA verification has been completed. Can be called before authorization
        /// </summary>
        public class SetApplicationVerificationToken : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setApplicationVerificationToken";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Unique identifier for the verification process as received from updateApplicationVerificationRequired or updateApplicationRecaptchaVerificationRequired
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("verification_id")]
            public long VerificationId { get; set; }

            /// <summary>
            /// Play Integrity API token for the Android application, or secret from push notification for the iOS application for application verification, or reCAPTCHA token for reCAPTCHA verifications;
            /// pass an empty string to abort verification and receive error VERIFICATION_FAILED for the request
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("token")]
            public string Token { get; set; }
        }

        /// <summary>
        /// Application or reCAPTCHA verification has been completed. Can be called before authorization
        /// </summary>
        public static Task<Ok> SetApplicationVerificationTokenAsync(
            this Client client, long verificationId = default, string token = default)
        {
            return client.ExecuteAsync(new SetApplicationVerificationToken
            {
                VerificationId = verificationId, Token = token
            });
        }
    }
}
// REUSE-IgnoreEnd