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
            /// The subtitle of a page
            /// </summary>
            public class PageBlockSubtitle : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockSubtitle";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Subtitle
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("subtitle")]
public RichText Subtitle { get; set; }


            }
        }
    }
}
