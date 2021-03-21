using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PageBlock : Object
        {
            /// <summary>
            /// A preformatted text paragraph
            /// </summary>
            public class PageBlockPreformatted : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockPreformatted";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Paragraph text
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("text")]
public RichText Text { get; set; }

/// <summary>
/// Programming language for which the text should be formatted
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("language")]
public string Language { get; set; }


            }
        }
    }
}
