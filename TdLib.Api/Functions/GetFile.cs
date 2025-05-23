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
        /// Returns information about a file. This is an offline method
        /// </summary>
        public class GetFile : Function<File>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the file to get
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }
        }

        /// <summary>
        /// Returns information about a file. This is an offline method
        /// </summary>
        public static Task<File> GetFileAsync(
            this Client client, int fileId = default)
        {
            return client.ExecuteAsync(new GetFile
            {
                FileId = fileId
            });
        }
    }
}
// REUSE-IgnoreEnd