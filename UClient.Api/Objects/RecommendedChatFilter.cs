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
        /// Describes a recommended chat filter
        /// </summary>
        public partial class RecommendedChatFilter : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "recommendedChatFilter";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// The chat filter
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("filter")]
public ChatFilter Filter { get; set; }

/// <summary>
/// 
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("description")]
public string Description { get; set; }


        }
    }
}
