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
            /// A collapsible block
            /// </summary>
            public class PageBlockDetails : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockDetails";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Always visible heading for the block
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("header")]
public RichText Header { get; set; }

/// <summary>
/// Block contents
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("page_blocks")]
public PageBlock[] PageBlocks { get; set; }

/// <summary>
/// True, if the block is open by default
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_open")]
public bool IsOpen { get; set; }


            }
        }
    }
}
