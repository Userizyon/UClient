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
            /// A pull quote
            /// </summary>
            public class PageBlockPullQuote : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockPullQuote";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Quote text
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("text")]
public RichText Text { get; set; }

/// <summary>
/// Quote credit
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("credit")]
public RichText Credit { get; set; }


            }
        }
    }
}
