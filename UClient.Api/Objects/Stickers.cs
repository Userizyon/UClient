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
        /// Represents a list of stickers
        /// </summary>
        public partial class Stickers : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "stickers";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// List of stickers
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("stickers")]
public Sticker[] Stickers_ { get; set; }


        }
    }
}
