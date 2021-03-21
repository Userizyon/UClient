using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Returns the extension of a file, guessed by its MIME type. Returns an empty string on failure. Can be called synchronously
        /// </summary>
        public class GetFileExtension : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getFileExtension";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// The MIME type of the file
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("mime_type")]
public string MimeType { get; set; }


        }

        /// <summary>
        /// Returns the extension of a file, guessed by its MIME type. Returns an empty string on failure. Can be called synchronously
        /// </summary>
        public static Task<Text> GetFileExtensionAsync(
            this Client client, string mimeType = default)
        {
            return client.ExecuteAsync(new GetFileExtension
            {
                MimeType = mimeType
            });
        }
    }
}
