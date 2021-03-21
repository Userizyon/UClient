using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// A personal document to be saved to Telegram Passport
        /// </summary>
        public partial class InputPersonalDocument : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inputPersonalDocument";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// List of files containing the pages of the document
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("files")]
public InputFile[] Files { get; set; }

/// <summary>
/// List of files containing a certified English translation of the document
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("translation")]
public InputFile[] Translation { get; set; }


        }
    }
}
