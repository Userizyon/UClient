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
        /// Returns the MIME type of a file, guessed by its extension. Returns an empty string on failure. Can be called synchronously
        /// </summary>
        public class GetFileMimeType : Function<Text>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getFileMimeType";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// The name of the file or path to the file
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("file_name")]
public string FileName { get; set; }


        }

        /// <summary>
        /// Returns the MIME type of a file, guessed by its extension. Returns an empty string on failure. Can be called synchronously
        /// </summary>
        public static Task<Text> GetFileMimeTypeAsync(
            this Client client, string fileName = default)
        {
            return client.ExecuteAsync(new GetFileMimeType
            {
                FileName = fileName
            });
        }
    }
}
